USE BDOptica2 
GO

--ELIMINAR TODOS LOS PROCEDIMIENTO, VISTAS Y TABLAS

DROP TABLE IF EXISTS dbo.PagosConConceptoMaterializado;

DROP VIEW IF EXISTS vwHistorialFinancieroCliente0;
DROP VIEW IF EXISTS vwHistorialFinancieroCliente1;
DROP VIEW IF EXISTS vwProductosPorOrden;
DROP VIEW IF EXISTS vwProductosPorOrdenDesglosado;
DROP VIEW IF EXISTS vwReportePagosDetallado0;
DROP VIEW IF EXISTS vwReportePagosDetallado1;
DROP VIEW IF EXISTS vwReporteVentaCompleta;
DROP VIEW IF EXISTS vwResumenMovimientosCaja;
DROP VIEW IF EXISTS vwResumenVentasFinanciero;

DROP PROCEDURE IF EXISTS dbo.PReporte_Concepto
DROP PROCEDURE IF EXISTS dbo.PReporte_ConceptoTotalVentas0
DROP PROCEDURE IF EXISTS dbo.PReporte_ConceptoTotalVentas1
DROP PROCEDURE IF EXISTS dbo.PReporte_Empleados
DROP PROCEDURE IF EXISTS dbo.PReporte_PagosConProductos
DROP PROCEDURE IF EXISTS dbo.PReporte_Productos
DROP PROCEDURE IF EXISTS dbo.PReporte_ResumenFinanciero
DROP PROCEDURE IF EXISTS dbo.PReporte_Semanal0
DROP PROCEDURE IF EXISTS dbo.PReporte_Semanal1
DROP PROCEDURE IF EXISTS dbo.PReporte_TipoPagos0
DROP PROCEDURE IF EXISTS dbo.PReporte_TipoPagos1
DROP PROCEDURE IF EXISTS dbo.RefrescarPagosConConcepto

DROP FUNCTION IF EXISTS dbo.fn_CalcularConceptoPago;
DROP FUNCTION IF EXISTS dbo.fnPagosConConcepto;


------------TABLA 

IF NOT EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
      AND TABLE_NAME = 'PagosConConceptoMaterializado'
)
BEGIN
    CREATE TABLE dbo.PagosConConceptoMaterializado (
        id INT PRIMARY KEY,
        idOrden INT,
        Monto DECIMAL(18,2),
        MontoPagar DECIMAL(18,2),
        Porcentaje DECIMAL(5,2),
        Concepto VARCHAR(20),
        Apartado DECIMAL(18,2),
	    Modo INT,
	    FechaPago DATETIME,
	    FechaActualizacion DATETIME DEFAULT GETDATE()
    );
END

GO
-------------------VISTAS


/* =======================================================
   VISTA 2: vwProductosPorOrden
   ======================================================= */
CREATE OR ALTER VIEW dbo.vwProductosPorOrden AS
SELECT 
    O.idOrden,
	F.FechaPago, 

    -- Montura (Categoría 3)
    MD.Montura,
    MD.CantidadM,
    MD.PrecioM,
    MD.TotalM,
    MD.DescuentoM,

    -- Cristales (Categoría 2)
    CD.Cristal,
    CD.CantidadC,
    CD.PrecioC,
    CD.TotalC,
    CD.DescuentoC,

    -- Misceláneos (Categorías 4,5,6)
    XD.Miscelaneo,
    XD.CantidadX,
    XD.PrecioX,
    XD.TotalX,
    XD.DescuentoX

FROM dbo.TOrden O
INNER JOIN TFormaPago F ON o.idOrden = F.idOrden

-- Montura
OUTER APPLY (
    SELECT TOP 1
        UPPER(TRIM(P.Nombre)) AS Montura,
        D.Cantidad AS CantidadM,
        CONVERT(DECIMAL(10,2), P.PrecioD1) AS PrecioM,
        CONVERT(DECIMAL(10,2), D.Cantidad * P.PrecioD1) AS TotalM,
        CONVERT(DECIMAL(10,2), 
            (D.Cantidad * P.PrecioD1) 
            - (D.Cantidad * P.PrecioD1 * (O.Descuento / NULLIF(O.SubTotal, 0)))
        ) AS DescuentoM
    FROM TDetalleOrden D
    INNER JOIN TProducto P ON D.idProducto = P.idProducto
    WHERE D.idOrden = O.idOrden AND P.idCategoria = 3
) AS MD

-- Cristales
OUTER APPLY (
    SELECT TOP 1
        UPPER(TRIM(P.Nombre)) AS Cristal,
        D.Cantidad AS CantidadC,
        CONVERT(DECIMAL(10,2), P.PrecioD1) AS PrecioC,
        CONVERT(DECIMAL(10,2), D.Cantidad * P.PrecioD1) AS TotalC,
        CONVERT(DECIMAL(10,2), 
            (D.Cantidad * P.PrecioD1) 
            - (D.Cantidad * P.PrecioD1 * (O.Descuento / NULLIF(O.SubTotal, 0)))
        ) AS DescuentoC
    FROM TDetalleOrden D
    INNER JOIN TProducto P ON D.idProducto = P.idProducto
    WHERE D.idOrden = O.idOrden AND P.idCategoria = 2
) AS CD

-- Misceláneos
OUTER APPLY (
    SELECT TOP 1
        UPPER(TRIM(P.Nombre)) AS Miscelaneo,
        D.Cantidad AS CantidadX,
        CONVERT(DECIMAL(10,2), P.PrecioD1) AS PrecioX,
        CONVERT(DECIMAL(10,2), D.Cantidad * P.PrecioD1) AS TotalX,
        CONVERT(DECIMAL(10,2), 
            (D.Cantidad * P.PrecioD1) 
            - (D.Cantidad * P.PrecioD1 * (O.Descuento / NULLIF(O.SubTotal, 0)))
        ) AS DescuentoX
    FROM TDetalleOrden D
    INNER JOIN TProducto P ON D.idProducto = P.idProducto
    WHERE D.idOrden = O.idOrden AND P.idCategoria IN (4,5,6)
) AS XD;
GO

------------------------------------------------------------------------------------------


CREATE OR ALTER VIEW vwProductosPorOrdenDesglosado AS
SELECT 
    O.idOrden,
    F.FechaPago,
    'Montura' AS TipoProducto,
    UPPER(TRIM(MP.Nombre)) AS NombreProducto,
    D.Cantidad,
    CONVERT(DECIMAL(10,2), MP.PrecioD1) AS PrecioUnitario,
    CONVERT(DECIMAL(10,2), D.Cantidad * MP.PrecioD1) AS TotalProducto
FROM TOrden O
INNER JOIN TFormaPago F ON O.idOrden = F.idOrden
INNER JOIN TDetalleOrden D ON D.idOrden = O.idOrden
INNER JOIN TProducto MP ON D.idProducto = MP.idProducto
WHERE MP.idCategoria = 3

UNION ALL

SELECT 
    O.idOrden,
    F.FechaPago,
    'Cristal' AS TipoProducto,
    UPPER(TRIM(CP.Nombre)) AS NombreProducto,
    D.Cantidad,
    CONVERT(DECIMAL(10,2), CP.PrecioD1),
    CONVERT(DECIMAL(10,2), D.Cantidad * CP.PrecioD1)
FROM TOrden O
INNER JOIN TFormaPago F ON O.idOrden = F.idOrden
INNER JOIN TDetalleOrden D ON D.idOrden = O.idOrden
INNER JOIN TProducto CP ON D.idProducto = CP.idProducto
WHERE CP.idCategoria = 2

UNION ALL

SELECT 
    O.idOrden,
    F.FechaPago,
    'Misceláneo' AS TipoProducto,
    UPPER(TRIM(XP.Nombre)) AS NombreProducto,
    D.Cantidad,
    CONVERT(DECIMAL(10,2), XP.PrecioD1),
    CONVERT(DECIMAL(10,2), D.Cantidad * XP.PrecioD1)
FROM TOrden O
INNER JOIN TFormaPago F ON O.idOrden = F.idOrden
INNER JOIN TDetalleOrden D ON D.idOrden = O.idOrden
INNER JOIN TProducto XP ON D.idProducto = XP.idProducto
WHERE XP.idCategoria IN (4,5,6);

GO
-----------------------------------------------------------------------------------------

/*
	REPORTE DETALLADO MODO PARA PROBAR ESTA CONSULTA
*/
--PARA LA MOVIL
CREATE OR ALTER VIEW dbo.vwReportePagosDetallado0 AS
WITH BasePagos AS (
    SELECT  
        F.id AS idPago,
        F.idOrden,
        O.FechaOrden,
        O.SubTotal,
        O.Descuento,
        O.Total AS MontoPagar,
        O.Jornada,
        O.idAsesor,
        O.idGerente,
        O.idOpto,
        O.idMarketing,
        F.FechaPago,
        F.Monto,
        F.idTipoPago,
        T.Nombre AS TipoPago,
        PCM.Porcentaje,
        PCM.Concepto,
        PCM.Apartado
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    INNER JOIN TTipoPago T ON F.idTipoPago = T.id
    LEFT JOIN dbo.PagosConConceptoMaterializado PCM 
        ON PCM.id = F.id AND PCM.Modo = 0  -- Cambia a 0 si deseas usar el umbral del 20%
),
PagosNumerados AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY idOrden ORDER BY FechaPago, idPago) AS NumPago
    FROM BasePagos
)
SELECT 
    ROW_NUMBER() OVER (ORDER BY idOrden, FechaPago, idPago) AS Item,
    CAST(FechaOrden AS DATE) AS Fecha_Venta,
    idOrden,
    SubTotal,
    Descuento,
    MontoPagar AS Total,
    CASE WHEN SubTotal > 0 THEN (Descuento * 100.0) / SubTotal ELSE 0 END AS Porc_Descuento,

    CAST(FechaPago AS DATE) AS Fecha_Abono,
    Monto,
    UPPER(LTRIM(RTRIM(TipoPago))) AS TipoPago,
    ISNULL(Porcentaje, 0) AS Anticipo,
    NumPago,
    Concepto,
    Apartado,

    UPPER(TRIM(EA.Nombre)) AS Asesor,
    UPPER(TRIM(EG.Nombre)) AS Gerente,
    UPPER(TRIM(EO.Nombre)) AS Optometrista,
    UPPER(TRIM(EM.Nombre)) AS Marketing,
    UPPER(TRIM(Jornada)) AS Jornada,

    '' AS Cobranza
FROM PagosNumerados P
LEFT JOIN TEmpleado EA ON EA.idEmpleado = P.idAsesor
LEFT JOIN TEmpleado EG ON EG.idEmpleado = P.idGerente
LEFT JOIN TEmpleado EO ON EO.idEmpleado = P.idOpto
LEFT JOIN TEmpleado EM ON EM.idEmpleado = P.idMarketing;

GO

--PARA EL MODO 1 PARA EL RESTO DE LAS OPTICAS
CREATE OR ALTER VIEW dbo.vwReportePagosDetallado1 AS
WITH BasePagos AS (
    SELECT  
        F.id AS idPago,
        F.idOrden,
        O.FechaOrden,
        O.SubTotal,
        O.Descuento,
        O.Total AS MontoPagar,
        O.Jornada,
        O.idAsesor,
        O.idGerente,
        O.idOpto,
        O.idMarketing,
        F.FechaPago,
        F.Monto,
        F.idTipoPago,
        T.Nombre AS TipoPago,
        PCM.Porcentaje,
        PCM.Concepto,
        PCM.Apartado
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    INNER JOIN TTipoPago T ON F.idTipoPago = T.id
    LEFT JOIN dbo.PagosConConceptoMaterializado PCM 
        ON PCM.id = F.id AND PCM.Modo = 1  -- Cambia a 0 si deseas usar el umbral del 20%
),
PagosNumerados AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY idOrden ORDER BY FechaPago, idPago) AS NumPago
    FROM BasePagos
)
SELECT 
    ROW_NUMBER() OVER (ORDER BY idOrden, FechaPago, idPago) AS Item,
    CAST(FechaOrden AS DATE) AS Fecha_Venta,
    idOrden,
    SubTotal,
    Descuento,
    MontoPagar AS Total,
    CASE WHEN SubTotal > 0 THEN (Descuento * 100.0) / SubTotal ELSE 0 END AS Porc_Descuento,

    CAST(FechaPago AS DATE) AS Fecha_Abono,
    Monto,
    UPPER(LTRIM(RTRIM(TipoPago))) AS TipoPago,
    ISNULL(Porcentaje, 0) AS Anticipo,
    NumPago,
    Concepto,
    Apartado,

    UPPER(TRIM(EA.Nombre)) AS Asesor,
    UPPER(TRIM(EG.Nombre)) AS Gerente,
    UPPER(TRIM(EO.Nombre)) AS Optometrista,
    UPPER(TRIM(EM.Nombre)) AS Marketing,
    UPPER(TRIM(Jornada)) AS Jornada,

    '' AS Cobranza
FROM PagosNumerados P
LEFT JOIN TEmpleado EA ON EA.idEmpleado = P.idAsesor
LEFT JOIN TEmpleado EG ON EG.idEmpleado = P.idGerente
LEFT JOIN TEmpleado EO ON EO.idEmpleado = P.idOpto
LEFT JOIN TEmpleado EM ON EM.idEmpleado = P.idMarketing;

GO
------------------------------------------------------------------------------------------


/* =======================================================
   VISTA 3: vwReporteVentaCompleta
   ======================================================= */
CREATE OR ALTER VIEW dbo.vwReporteVentaCompleta AS
WITH PagosAcumulados AS (
    SELECT 
        idOrden,
        FechaPago,
        Monto,
        ROW_NUMBER() OVER (
            PARTITION BY idOrden 
            ORDER BY FechaPago, id
        ) AS NumPago,
        SUM(Monto) OVER (
            PARTITION BY idOrden 
            ORDER BY FechaPago, id 
            ROWS UNBOUNDED PRECEDING
        ) AS Acumulado
    FROM TFormaPago
)
SELECT 
    --ROW_NUMBER() OVER(ORDER BY RPD.ID ASC) AS ID,
	--RPD.ID,
    RPD.Fecha_Venta,
    RPD.idOrden,
    RPD.SubTotal,
    RPD.Descuento,
    RPD.Total,
    CONVERT(DECIMAL(10,2), RPD.Porc_Descuento) AS Porcentaje, 

    RPD.Fecha_Abono,
    RPD.Monto,

    RPD.Total - ISNULL(PA.Acumulado, 0) AS Deuda,
	-- CAST(RPD.Porcentaje AS DECIMAL(5,2)) AS Anticipo

    RPD.Anticipo AS Anticipo,
    RPD.TipoPago,
    RPD.Apartado,
    RPD.Concepto,

    PPO.Montura,
    PPO.CantidadM AS Cantidad_Montura,
    PPO.PrecioM AS Precio_Montura,
    PPO.TotalM AS Total_Montura,
    PPO.DescuentoM AS Descuento_Montura,

    PPO.Cristal,
    PPO.CantidadC AS Cantidad_Cristal,
    PPO.PrecioC AS Precio_Cristal,
    PPO.TotalC AS Total_Cristal,
    PPO.DescuentoC AS Descuento_Cristal,

    PPO.Miscelaneo,
    PPO.CantidadX AS Cantidad_Miscelaneo,
    PPO.PrecioX AS Precio_Miscelaneo,
    PPO.TotalX AS Total_Miscelaneo,
    PPO.DescuentoX AS Descuento_Miscelaneo,

    RPD.Asesor,
    RPD.Gerente,
    RPD.Optometrista,
    RPD.Marketing,
    RPD.Jornada

FROM vwReportePagosDetallado1 RPD
LEFT JOIN vwProductosPorOrden PPO ON RPD.idOrden = PPO.idOrden
LEFT JOIN PagosAcumulados PA ON RPD.idOrden = PA.idOrden AND RPD.NumPago = PA.NumPago;

GO
-----------------------------------------------------------------------------------------




/* =======================================================
   VISTA 3: vwResumenMovimientosCaja
   ======================================================= */
CREATE OR ALTER VIEW vwResumenMovimientosCaja AS
SELECT
    CAST(PD.Fecha_Abono AS DATE) AS FechaMovimiento,
    PD.TipoPago,
    PD.Concepto,  -- Este es calculado desde la vista vwReportePagosDetallado
    COUNT(*) AS CantidadMovimientos,
    SUM(PD.Monto) AS MontoTotal,

    -- Totales por tipo de concepto (calculados)
    SUM(CASE WHEN PD.Concepto = 'VENTA' THEN PD.Monto ELSE 0 END)     AS TotalVentas,
    SUM(CASE WHEN PD.Concepto = 'APARTADO' THEN PD.Monto ELSE 0 END)  AS TotalApartados,
    SUM(CASE WHEN PD.Concepto = 'RETIRO' THEN PD.Monto ELSE 0 END)    AS TotalRetiros,
    SUM(CASE WHEN PD.Concepto = 'ABONO' THEN PD.Monto ELSE 0 END)     AS TotalAbonos

FROM 
    vwReportePagosDetallado1 PD
GROUP BY 
    CAST(PD.Fecha_Abono AS DATE), 
    PD.TipoPago, 
    PD.Concepto

GO
----------------------------------------------------------------------------------------------


/* =======================================================
   VISTA 3: vwResumenVentasFinanciero
   ======================================================= */
CREATE OR ALTER VIEW vwResumenVentasFinanciero AS
SELECT 
    CAST(FP.FechaPago AS DATE) AS FechaPago,
    FORMAT(FP.FechaPago, 'MMMM') AS Mes,
    DATEPART(QUARTER, FP.FechaPago) AS Trimestre,
    DATEPART(YEAR, FP.FechaPago) AS Año,
    FP.idTipoPago,
    COUNT(*) AS CantidadTransacciones,
    SUM(FP.Monto) AS TotalEnCajaUSD
FROM 
    TFormaPago FP
GROUP BY 
    CAST(FP.FechaPago AS DATE), 
    FORMAT(FP.FechaPago, 'MMMM'), 
    DATEPART(QUARTER, FP.FechaPago), 
    DATEPART(YEAR, FP.FechaPago),
    FP.idTipoPago

GO

--------------------------------------------------------------------------------------------------
/* =======================================================
	Vista: vwHistorialFinancieroCliente

	¿Qué puedes hacer con esta vista?
	- Detectar clientes con deuda activa (SaldoPendiente > 0)
	- Ver cuántos pagos ha realizado cada cliente (TotalMovimientos)
	- Saber cuántas órdenes distintas ha generado (TotalOrdenes)
	- Exportar a Excel o mostrar en tu app con filtros por nombre, fecha o saldo

   ======================================================= */

   --PARTE 1 PARA TODAS LAS OPTICAS EXCEPTO PARA LA MOVIL

CREATE OR ALTER VIEW vwHistorialFinancieroCliente1 AS
SELECT
    P.idOrden,
    C.Nombre,

    --COUNT(P.idPago) AS TotalMovimientos,
	P.NumPago,
    COUNT(DISTINCT O.idOrden) AS TotalOrdenes,

    SUM(O.Total) AS TotalOrdenado,

    SUM(CASE WHEN P.Concepto = 'VENTA' THEN P.Monto ELSE 0 END)     AS TotalVentas,
    SUM(CASE WHEN P.Concepto = 'APARTADO' THEN P.Monto ELSE 0 END)  AS TotalApartados,
    SUM(CASE WHEN P.Concepto = 'ABONO' THEN P.Monto ELSE 0 END)     AS TotalAbonos,
    SUM(CASE WHEN P.Concepto = 'RETIRO' THEN P.Monto ELSE 0 END)    AS TotalRetiros,

    SUM(P.Monto) AS TotalPagado,
    SUM(O.Total) - SUM(P.Monto) AS SaldoPendiente,

    -- Porcentaje de cumplimiento (evita división por cero)
    CASE 
        WHEN SUM(O.Total) = 0 THEN 0
        ELSE ROUND(SUM(P.Monto) * 100.0 / SUM(O.Total), 2)
    END AS PorcentajeCumplimiento,

    MAX(P.Fecha_Abono) AS UltimoMovimiento

FROM 
    vwReportePagosDetallado1 P
INNER JOIN TClientes C ON C.idCliente = P.idOrden 
INNER JOIN TOrden O ON O.idOrden = P.idOrden
GROUP BY 
    P.idOrden, C.Nombre, P.NumPago 

GO


	--PARTE 0 PARA LA MOVIL
CREATE OR ALTER VIEW vwHistorialFinancieroCliente0 AS
SELECT
    P.idOrden,
    C.Nombre,

    --COUNT(P.idPago) AS TotalMovimientos,
	P.NumPago,
    COUNT(DISTINCT O.idOrden) AS TotalOrdenes,

    SUM(O.Total) AS TotalOrdenado,

    SUM(CASE WHEN P.Concepto = 'VENTA' THEN P.Monto ELSE 0 END)     AS TotalVentas,
    SUM(CASE WHEN P.Concepto = 'APARTADO' THEN P.Monto ELSE 0 END)  AS TotalApartados,
    SUM(CASE WHEN P.Concepto = 'ABONO' THEN P.Monto ELSE 0 END)     AS TotalAbonos,
    SUM(CASE WHEN P.Concepto = 'RETIRO' THEN P.Monto ELSE 0 END)    AS TotalRetiros,

    SUM(P.Monto) AS TotalPagado,
    SUM(O.Total) - SUM(P.Monto) AS SaldoPendiente,

    -- Porcentaje de cumplimiento (evita división por cero)
    CASE 
        WHEN SUM(O.Total) = 0 THEN 0
        ELSE ROUND(SUM(P.Monto) * 100.0 / SUM(O.Total), 2)
    END AS PorcentajeCumplimiento,

    MAX(P.Fecha_Abono) AS UltimoMovimiento

FROM 
    vwReportePagosDetallado0 P
INNER JOIN TClientes C ON C.idCliente = P.idOrden 
INNER JOIN TOrden O ON O.idOrden = P.idOrden
GROUP BY 
    P.idOrden, C.Nombre, P.NumPago 

GO

-------------------------------------------------------------------------


--------PROCEDIMIENTOS


/* =======================================================
   Procedimiento: PReporte_Concepto 


   PROCEDIMIENTO PARA MOSTRAR LOS CONCEPTOS VENTAS, APARTADOS, RETIROS, ABONOS POR FECHA
   ======================================================= */
CREATE OR ALTER PROCEDURE PReporte_Concepto
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT 
			Concepto,
			COUNT(*) AS TotalPagos,
			SUM(Monto) AS MontoTotal
		FROM dbo.PagosConConceptoMaterializado 
		WHERE FechaPago BETWEEN @FechaIni AND @FechaFin
		GROUP BY Concepto
		ORDER BY MontoTotal DESC;

END

GO

CREATE OR ALTER PROCEDURE PReporte_ConceptoTotalVentasMejorado0
    @FechaIni DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Venta al 100% (Contado directo sin apartados, abonos ni retiros)
    SELECT 'Venta al 100% (Contado)' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Venta'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Apartado', 'Abono', 'Retiro')
      )
      AND (
          SELECT COUNT(*) FROM vwReportePagosDetallado0 X
          WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta'
      ) = 1

    UNION ALL

    -- 2. Apartado → Venta (sin retiro)
    SELECT 'Apartado → Venta' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Apartado'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
      AND EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 X
          WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta'
      )
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 Y
          WHERE Y.idOrden = P.idOrden AND Y.Concepto = 'Retiro'
      )

    UNION ALL

    -- 3. Apartado → Venta → Retiro
    SELECT 'Apartado → Venta → Retiro' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Apartado'
      AND EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 X
          WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta'
      )
      AND EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 Y
          WHERE Y.idOrden = P.idOrden AND Y.Concepto = 'Retiro'
      )

    UNION ALL

    -- 4. Apartado vigente (sin venta ni retiro)
    SELECT 'Apartado Periodo' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Apartado'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Venta', 'Retiro')
      )

      UNION ALL

    -- 4. Apartado vigente (sin venta ni retiro en toda la base de datos sin fecha periodo)
    SELECT 'Apartado Real' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Apartado'
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado0 X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Venta', 'Retiro')
      )

    UNION ALL

    -- 5. Orden completada y retirada (retiro directo)
    SELECT 'Orden completada y retirada' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Retiro'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin

    UNION ALL

    -- 6. Venta (Crédito)
    SELECT 'Venta (Crédito)' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado0 P
    WHERE P.Concepto = 'Venta'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin

    UNION ALL

    -- 7. Apartados no concretados con 2 pagos y sin venta ni retiro
    SELECT 'Apartado no completado (2 pagos)' AS Categoria,
           COUNT(*) AS TotalOrdenes,
           SUM(Total) AS MontoTotal
    FROM (
        SELECT idOrden, SUM(Total) AS Total
        FROM vwReportePagosDetallado0
        WHERE Concepto = 'Apartado'
        GROUP BY idOrden
        HAVING COUNT(*) = 2
           AND NOT EXISTS (
               SELECT 1 FROM vwReportePagosDetallado0
               WHERE idOrden = vwReportePagosDetallado0.idOrden
                 AND Concepto IN ('Venta', 'Retiro')
           )
    ) AS P

    ORDER BY MontoTotal DESC;
END

GO

CREATE OR ALTER PROCEDURE PReporte_ConceptoTotalVentasMejorado1
    @FechaIni DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Venta al 100% (Contado directo sin apartados, abonos ni retiros)
    SELECT 'Venta al 100% (Contado)' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Venta'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Apartado', 'Abono', 'Retiro')
      )
      AND (
          SELECT COUNT(*) FROM vwReportePagosDetallado1 X
          WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta'
      ) = 1

    UNION ALL

    -- 2. Apartado → Venta (sin retiro)
    SELECT 'Apartado → Venta' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Apartado'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
      AND EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 X
          WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta'
      )
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 Y
          WHERE Y.idOrden = P.idOrden AND Y.Concepto = 'Retiro'
      )

    UNION ALL

    -- 3. Apartado → Venta → Retiro
    SELECT 'Apartado → Venta → Retiro' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Apartado'
      AND EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 X
          WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta'
      )
      AND EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 Y
          WHERE Y.idOrden = P.idOrden AND Y.Concepto = 'Retiro'
      )

    UNION ALL

    -- 4. Apartado vigente (sin venta ni retiro)
    SELECT 'Apartado Periodo' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Apartado'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Venta', 'Retiro')
      )

      UNION ALL

    -- 4. Apartado vigente (sin venta ni retiro en toda la base de datos sin fecha periodo)
    SELECT 'Apartado Real' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Apartado'
      AND NOT EXISTS (
          SELECT 1 FROM vwReportePagosDetallado1 X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Venta', 'Retiro')
      )

    UNION ALL

    -- 5. Orden completada y retirada (retiro directo)
    SELECT 'Orden completada y retirada' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Retiro'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin

    UNION ALL

    -- 6. Venta (Crédito)
    SELECT 'Venta (Crédito)' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM vwReportePagosDetallado1 P
    WHERE P.Concepto = 'Venta'
      AND P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin

    UNION ALL

    -- 7. Apartados no concretados con 2 pagos y sin venta ni retiro
    SELECT 'Apartado no completado (2 pagos)' AS Categoria,
           COUNT(*) AS TotalOrdenes,
           SUM(Total) AS MontoTotal
    FROM (
        SELECT idOrden, SUM(Total) AS Total
        FROM vwReportePagosDetallado1
        WHERE Concepto = 'Apartado'
        GROUP BY idOrden
        HAVING COUNT(*) = 2
           AND NOT EXISTS (
               SELECT 1 FROM vwReportePagosDetallado1
               WHERE idOrden = vwReportePagosDetallado1.idOrden
                 AND Concepto IN ('Venta', 'Retiro')
           )
    ) AS P

    ORDER BY MontoTotal DESC;
END

--EXEC PReporte_ConceptoTotalVentasMejorado1 '01/06/2025 00:00:00','30/06/2025 23:59:59';


/*
### 🔹 1. **Venta al 100% (Contado)**
> **¿Qué representa?**  
Son órdenes que se pagaron de una sola vez, sin haber pasado antes por un apartado, abono o retiro. Es decir, el cliente pagó el monto total directamente al momento de realizar la compra.

> **¿Cómo se identifica?**  
- Solo tiene un movimiento con concepto `'Venta'`.
- No existe ningún `'Apartado'`, `'Abono'` ni `'Retiro'` vinculado a esa orden.

> 🧾 Ejemplo: “Llego, pago todo y me voy con mi producto en mano (o lo retiro luego)”.

---

### 🔹 2. **Apartado → Venta**
> **¿Qué representa?**  
Órdenes que comenzaron como **apartado**, y luego el cliente concretó la **venta**. Sin embargo, no se ha retirado el producto aún.

> **¿Cómo se identifica?**  
- Tiene al menos un `'Apartado'`.
- Tiene al menos una `'Venta'`.
- **No** tiene `'Retiro'`.

> 🧾 Ejemplo: “Reservé el producto, lo terminé de pagar, pero aún no lo he retirado”.

---

### 🔹 3. **Apartado → Venta → Retiro**
> **¿Qué representa?**  
Órdenes que cumplieron **todo el ciclo completo**: empezaron como apartado, luego fueron pagadas totalmente (venta), y finalmente el producto fue retirado.

> **¿Cómo se identifica?**  
- Tiene `'Apartado'`, `'Venta'` y `'Retiro'`.

> 🧾 Ejemplo: “Reservé, lo pagué, y vine a buscar mi producto. ¡Todo en orden!”

---

### 🔹 4. **Apartado vigente (sin fecha)**
> **¿Qué representa?**  
Apartados que **nunca fueron completados** como venta ni retiro. Se listan sin importar la fecha, ya que pueden estar olvidados, vencidos o en espera.

> **¿Cómo se identifica?**  
- Tiene uno o más `'Apartado'`.
- **No** tiene `'Venta'` ni `'Retiro'` asociados.
- No se filtra por fecha: muestra el histórico total.

> 🧾 Ejemplo: “Reservé un producto... y nunca más volví”.

---

### 🔹 5. **Orden completada y retirada (retiro directo)**
> **¿Qué representa?**  
Casos en los que el producto fue retirado, independientemente de si fue venta directa o tras un apartado.

> **¿Cómo se identifica?**  
- Tiene registros con concepto `'Retiro'` en el rango de fechas seleccionado.

> 🧾 Ejemplo: “Vine hoy a buscar mi producto. Lo haya pagado antes o no, este es el acto del retiro.”

---

### 🔹 6. **Venta (Crédito)**
> **¿Qué representa?**  
Ventas registradas como concepto `'Venta'` dentro del período solicitado. A diferencia del “Contado”, esta categoría **sí puede incluir ventas que se originaron desde apartados o abonos**.

> **¿Cómo se identifica?**  
- Concepto = `'Venta'`
- Fecha de abono dentro del rango indicado.
- No se evalúa si tuvo apartados o no: simplemente es una venta registrada.

> 🧾 Ejemplo: “Es una venta normal registrada este mes, venga de donde venga (apartado, abono, contado)”.

---

### 🔹 7. **Apartado no completado (2 pagos)**
> **¿Qué representa?**  
Apartados que tuvieron **exactamente 2 pagos** (quizás en cuotas), pero **no se concretaron como venta ni hubo retiro**.

> **¿Cómo se identifica?**  
- Solo tiene 2 pagos con concepto `'Apartado'`.
- **No** tiene `'Venta'` ni `'Retiro'`.

> 🧾 Ejemplo: “Reservé el producto, hice dos pagos, pero jamás finalicé la compra”.

---

### 🔍 Sugerencia adicional
Para mejorar la trazabilidad, podrías considerar una columna adicional con el porcentaje de avance del cliente en el ciclo (por ejemplo, "50%" si llegó hasta Venta pero no Retiro). Si te interesa, puedo ayudarte a implementarlo.

¿Quieres que te lo presente también en forma de tabla resumen visual? O incluso integrarlo a un dashboard en Excel o Power BI si estás cruzando con más datos. ¡Tú dime!

*/

GO
--------------------------------------------------------------------------------

CREATE OR ALTER PROCEDURE PReporte_Empleados
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT 
			--Item,
			CAST(Fecha_Venta AS DATE) AS Fecha_Venta,
			CAST(Fecha_Abono AS DATE) AS Fecha_Abono,
			idOrden,
			--Monto,
			Total,
			--Anticipo,
			--TipoPago,
			Concepto,
			Apartado,
			Asesor,
			Gerente,
			Optometrista
			--Marketing,
			--Jornada
		FROM dbo.vwReportePagosDetallado1
		WHERE Fecha_Abono BETWEEN @FechaIni and @FechaFin
		ORDER BY idOrden;

END

GO
------------------------------------------------------------------------------------


/*
ESTE PROCEDIMIENTO SE UTILIZA PARA MOSTRAR LOS PRODUCTOS REFERENCIADOS 
A LAS ORDENES DE VENTAS
*/
CREATE OR ALTER PROCEDURE PReporte_Productos
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT 
			*
		FROM vwProductosPorOrden
		WHERE FechaPago BETWEEN @FechaIni AND @FechaFin
		ORDER BY idOrden;

END

GO

CREATE OR ALTER PROCEDURE PReporte_PagosConProductos
    @FechaIni DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        -- Datos de pagos
        CAST(P.Fecha_Venta AS DATE) AS Fecha_Venta,
        P.idOrden,
        P.SubTotal,
        P.Descuento,
        P.Total,
        CONVERT(DECIMAL(10,2), P.Porc_Descuento) AS Porcentaje,
        CAST(P.Fecha_Abono AS DATE) AS Fecha_Abono,
        P.Monto,
        P.Anticipo,
        P.TipoPago,
        P.Apartado,
        P.Concepto,

        -- Datos de producto
        PR.Montura, 
        PR.CantidadM, 
        PR.PrecioM,
        PR.TotalM,
		PR.DescuentoM,
        
		PR.Cristal,
		PR.CantidadC,
		PR.PrecioC,
		PR.TotalC,
		PR.DescuentoC,
		
		PR.Miscelaneo,
		PR.CantidadX,
		PR.PrecioX,
		PR.TotalX,
		PR.DescuentoX,

		--Datos de los empleados
		P.Asesor,
        P.Gerente,
        P.Marketing

    FROM vwReportePagosDetallado1 P
    LEFT JOIN vwProductosPorOrden PR 
        ON PR.idOrden = P.idOrden
       AND PR.FechaPago BETWEEN @FechaIni AND @FechaFin

    WHERE P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
    ORDER BY P.idOrden, P.Fecha_Abono;
END

GO
----------------------------------------------------------------------------------


CREATE OR ALTER PROCEDURE PReporte_ResumenFinanciero
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT *
		FROM vwResumenVentasFinanciero
		WHERE FechaPago BETWEEN @FechaIni AND @FechaFin
		ORDER BY FechaPago

END

GO
---------------------------------------------------------------------------------


/* =======================================================
   Procedimiento 3: PReporte_Semanal

   PROCEDIMIENTO PARA MOSTRAR LOS DATOS DE LAS VENTAS HASTA EL CONCEPTO 
   ======================================================= */

   --PARA LA MOVIL
CREATE OR ALTER PROCEDURE PReporte_Semanal0
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT 
			CAST(P.Fecha_Venta AS DATE) AS Fecha_Venta,
			P.idOrden,
			P.SubTotal,
			P.Descuento, 
			P.Total,
			CONVERT(DECIMAL(10,2), P.Porc_Descuento) AS Porcentaje,
			CAST(P.Fecha_Abono AS DATE) AS Fecha_Abono,
			P.Monto,
			P.Anticipo,
			P.TipoPago,
			P.Apartado,
			P.Concepto,
			P.Asesor,
			P.Gerente,
			P.Marketing 
		FROM dbo.vwReportePagosDetallado0 P
		WHERE P.Fecha_Abono BETWEEN @FechaIni and @FechaFin
		ORDER BY P.idOrden;

END

GO

---PARA LAS OPTICAS EXCEPTO LA MOVIL
CREATE OR ALTER PROCEDURE PReporte_Semanal1
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT 
			CAST(P.Fecha_Venta AS DATE) AS Fecha_Venta,
			P.idOrden,
			P.SubTotal,
			P.Descuento, 
			P.Total,
			CONVERT(DECIMAL(10,2), P.Porc_Descuento) AS Porcentaje,
			CAST(P.Fecha_Abono AS DATE) AS Fecha_Abono,
			P.Monto,
			P.Anticipo,
			P.TipoPago,
			P.Apartado,
			P.Concepto,
			P.Asesor,
			P.Gerente,
			P.Marketing 
		FROM dbo.vwReportePagosDetallado1 P
		WHERE P.Fecha_Abono BETWEEN @FechaIni and @FechaFin
		ORDER BY P.idOrden;

END

GO
---------------------------------------------------------------------------



/* =======================================================
   Procedimiento 3: PReporte_TipoPagos 

   PROCEDIMIENTO PARA MOSTRAR LOS TIPOS DE PAGOS
   ======================================================= */

---PARA LA MOVIL
CREATE OR ALTER PROCEDURE PReporte_TipoPagos0
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT
			P.TipoPago,
			COUNT(*) AS CantidadMovimientos,
			SUM(P.Monto) AS TotalPorTipoPago
		FROM vwReportePagosDetallado0 P
		WHERE P.Fecha_Abono  BETWEEN @FechaIni AND @FechaFin
		GROUP BY P.TipoPago

END

GO

---PARA LAS OPTICAS
CREATE OR ALTER PROCEDURE PReporte_TipoPagos1
	@FechaIni DATETIME,
	@FechaFin DATETIME
AS
BEGIN

		SELECT
			P.TipoPago,
			COUNT(*) AS CantidadMovimientos,
			SUM(P.Monto) AS TotalPorTipoPago
		FROM vwReportePagosDetallado1 P
		WHERE P.Fecha_Abono  BETWEEN @FechaIni AND @FechaFin
		GROUP BY P.TipoPago

END

GO
--------------------------------------------------------------------------------------

---PARA ACTUALIZAR LA TABLA CON LA INFORMACIÒN DE LAS TORDEN
CREATE OR ALTER PROCEDURE dbo.RefrescarPagosConConcepto
    @Modo INT
AS
BEGIN
    SET NOCOUNT ON;

    --DELETE FROM dbo.PagosConConceptoMaterializado WHERE Modo = @Modo;
	TRUNCATE TABLE dbo.PagosConConceptoMaterializado

    INSERT INTO dbo.PagosConConceptoMaterializado (
        id, idOrden, Monto, MontoPagar, Porcentaje, Concepto, Apartado, Modo, FechaPago
    )
    SELECT 
        id, idOrden, Monto, MontoPagar, Porcentaje, Concepto, Apartado, @Modo, FechaPago
    FROM dbo.fnPagosConConcepto(@Modo);
END;


GO
-----------------------------------------------------------------------------------------------


-------------------FUNCIONES


/*
	FUNCION [fnPagosConConcepto]

*/
CREATE OR ALTER FUNCTION fnPagosConConcepto (@Modo INT)
RETURNS TABLE
AS
RETURN
WITH Porcentajes AS (
    SELECT 
        F.id,
        F.idOrden,
        F.Monto,
		F.FechaPago, 
        O.Total AS MontoPagar,
        CAST(
            SUM(F.Monto) OVER (
                PARTITION BY F.idOrden  
                ORDER BY F.id  
                ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
            ) * 100.0 / O.Total AS DECIMAL(5,2)
        ) AS Porcentaje
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
),
Umbrales AS (
    SELECT 
        CASE WHEN @Modo = 0 THEN 20.0 ELSE 40.0 END AS Umbral
),
PagosPorOrden AS (
    SELECT idOrden, COUNT(*) AS TotalPagos
    FROM Porcentajes
    GROUP BY idOrden
),
PrimeraVenta AS (
    SELECT P.idOrden, MIN(P.id) AS idVenta
    FROM Porcentajes P
    CROSS JOIN Umbrales U
    WHERE P.Porcentaje >= U.Umbral AND P.Porcentaje < 100
    GROUP BY P.idOrden
),
MarcarVentaPorRetiroDirecto AS (
    SELECT P.idOrden, MAX(P.id) AS idVentaFinal
    FROM Porcentajes P
    WHERE P.Porcentaje = 100 AND P.idOrden NOT IN (
        SELECT idOrden FROM PrimeraVenta
    )
    GROUP BY P.idOrden
)
SELECT 
    P.id,
    P.idOrden,
    P.Monto,
    P.MontoPagar,
    P.Porcentaje,
	P.FechaPago,
    CASE
        WHEN P.Porcentaje = 100 AND PPO.TotalPagos = 1 THEN 'Venta'
        WHEN P.Porcentaje = 100 AND P.id = MVP.idVentaFinal THEN 'Venta'
        WHEN P.Porcentaje = 100 THEN 'Retiro'
        WHEN P.id = PV.idVenta THEN 'Venta'
        WHEN P.Porcentaje >= U.Umbral THEN 'Abono'
        WHEN P.Porcentaje < U.Umbral THEN 'Apartado'
        ELSE 'N/A'
    END AS Concepto,
    CASE 
        WHEN 
            (P.Porcentaje < U.Umbral  
            OR (
                P.Porcentaje = 100 AND P.id = MVP.idVentaFinal  
                AND PPO.TotalPagos > 1
                AND NOT EXISTS (
                    SELECT 1 FROM PrimeraVenta WHERE idOrden = P.idOrden
                )
            )
        ) THEN P.MontoPagar
        ELSE 0  
    END AS Apartado
FROM Porcentajes P
CROSS JOIN Umbrales U
LEFT JOIN PagosPorOrden PPO ON P.idOrden = PPO.idOrden
LEFT JOIN PrimeraVenta PV ON P.idOrden = PV.idOrden
LEFT JOIN MarcarVentaPorRetiroDirecto MVP ON P.idOrden = MVP.idOrden;

GO
-------------------------------------------------------------------------------------------


CREATE OR ALTER FUNCTION dbo.fn_CalcularConceptoPago (
    @NumPago INT,
    @MontoPagar DECIMAL(18,2),
    @TotalOrden DECIMAL(18,2)
)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @Concepto VARCHAR(20)

    IF @MontoPagar < 0
        SET @Concepto = 'RETIRO'
    ELSE IF @NumPago IS NULL OR @MontoPagar IS NULL OR @TotalOrden IS NULL
        SET @Concepto = 'ERROR'
    ELSE IF @NumPago = 1 AND @MontoPagar = @TotalOrden
        SET @Concepto = 'VENTA'
    ELSE IF @NumPago = 1 AND @MontoPagar < @TotalOrden
        SET @Concepto = 'APARTADO'
    ELSE IF @NumPago > 1
        SET @Concepto = 'ABONO'
    ELSE
        SET @Concepto = 'ERROR'

    RETURN @Concepto
END



