USE BDOptica2 
GO

--ELIMINAR TODOS LOS PROCEDIMIENTO, VISTAS Y TABLAS viejos

DROP TABLE IF EXISTS dbo.PagosConConceptoMaterializado; 
GO
DROP VIEW IF EXISTS vwHistorialFinancieroCliente0; 
GO
DROP VIEW IF EXISTS vwHistorialFinancieroCliente1; 
GO
DROP VIEW IF EXISTS vwProductosPorOrden; 
GO
DROP VIEW IF EXISTS vwProductosPorOrdenDesglosado; 
GO
DROP VIEW IF EXISTS vwReportePagosDetallado0; 
GO
DROP VIEW IF EXISTS vwReportePagosDetallado1; 
GO
DROP VIEW IF EXISTS vwReporteVentaCompleta; 
GO
DROP VIEW IF EXISTS vwResumenMovimientosCaja; 
GO
DROP VIEW IF EXISTS vwResumenVentasFinanciero; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Concepto0;
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Concepto;
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Concepto1;
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_ConceptoTotalVentas0; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_ConceptoTotalVentas1; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Empleados; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_PagosConProductos; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Productos; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_ResumenFinanciero; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Semanal0; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_Semanal1; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_TipoPagos0; 
GO
DROP PROCEDURE IF EXISTS dbo.PReporte_TipoPagos1; 
GO
DROP PROCEDURE IF EXISTS dbo.RefrescarPagosConConcepto; 
GO

DROP FUNCTION IF EXISTS dbo.fn_CalcularConceptoPago; 
GO
DROP FUNCTION IF EXISTS dbo.fnPagosConConcepto; 
GO

TRUNCATE TABLE dbo.PagosConConceptoMaterializado

--ELIMINAR TODOS LOS PROCEDIMIENTO, VISTAS Y TABLAS

DROP TABLE IF EXISTS dbo.PagosConConceptoMaterializado; 
GO

DROP VIEW IF EXISTS dbo.vwProductosPorOrden; 
GO

DROP VIEW IF EXISTS dbo.vwProductosPorOrdenDesglosado; 
GO

DROP VIEW IF EXISTS dbo.vwProductosPorOrden; 
GO

DROP PROCEDURE IF EXISTS dbo.PReporte_Semanal; 
GO

DROP PROCEDURE IF EXISTS dbo.PReporte_TipoPagos; 
GO

DROP PROCEDURE IF EXISTS dbo.PReporte_Concepto; 
GO

DROP PROCEDURE IF EXISTS dbo.RefrescarPagosConConcepto; 
GO

DROP PROCEDURE IF EXISTS dbo.PReporte_ConceptoTotalVentas; 
GO

DROP FUNCTION IF EXISTS fnPagosConConcepto; 
GO

DROP FUNCTION IF EXISTS fnPagosDetalladosModo; 
GO

------------TABLA 

IF NOT EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_SCHEMA = 'dbo'
      AND TABLE_NAME = 'PagosConConceptoMaterializado'
)
    BEGIN
        CREATE TABLE dbo.PagosConConceptoMaterializado (
        id INT IDENTITY(1,1) PRIMARY KEY,
        FechaVenta DATE,
        IdOrden INT,
        SubTotal DECIMAL(18,2),
        Descuento DECIMAL(18,2),
        Total DECIMAL(18,2),
        Porcentaje DECIMAL(18,2),
        FechaPago DATETIME,
        MontoAbonado DECIMAL(18,2), 
        Anticipo DECIMAL(5,2),
        TipoPago NVARCHAR(50),
        Apartado DECIMAL(18,2),
        Concepto VARCHAR(20),
        NumPago INT,
        Asesor NVARCHAR(60),
        Optometrista NVARCHAR(60),
        Gerente NVARCHAR(60),
        Marketing NVARCHAR(60),
        Modo INT,
        FechaActualizacion DATETIME DEFAULT GETDATE()
    );
END


------------------ INDICES -----------------------------

-- INDICES PATA LA TABLA TFORMAPAGO
-- ========================================
-- 🚀 INDICES PARA TABLA: TFormaPago
-- ========================================
IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_TFormaPago_idOrden' AND object_id = OBJECT_ID('TFormaPago')
)
CREATE NONCLUSTERED INDEX IX_TFormaPago_idOrden ON TFormaPago(idOrden);

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_TFormaPago_FechaPago' AND object_id = OBJECT_ID('TFormaPago')
)
CREATE NONCLUSTERED INDEX IX_TFormaPago_FechaPago ON TFormaPago(FechaPago);

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_TFormaPago_idTipoPago' AND object_id = OBJECT_ID('TFormaPago')
)
CREATE NONCLUSTERED INDEX IX_TFormaPago_idTipoPago ON TFormaPago(idTipoPago);

-- ========================================
-- 🚀 INDICES PARA TABLA: TOrden
-- ========================================
IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_TOrden_idOrden' AND object_id = OBJECT_ID('TOrden')
)
CREATE NONCLUSTERED INDEX IX_TOrden_idOrden ON TOrden(idOrden);

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_TOrden_idMarketing' AND object_id = OBJECT_ID('TOrden')
)
CREATE NONCLUSTERED INDEX IX_TOrden_idMarketing ON TOrden(idMarketing);

-- ========================================
-- 🚀 INDICES PARA TABLA: PagosConConceptoMaterializado
-- ========================================
--IF NOT EXISTS (
--    SELECT 1 FROM sys.indexes 
--    WHERE name = 'IX_PCM_id' AND object_id = OBJECT_ID('PagosConConceptoMaterializado')
--)
--CREATE CLUSTERED INDEX IX_PCM_id ON PagosConConceptoMaterializado(id);

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_PCM_Modo' AND object_id = OBJECT_ID('PagosConConceptoMaterializado')
)
CREATE NONCLUSTERED INDEX IX_PCM_idOrden_Modo ON PagosConConceptoMaterializado(idOrden, Modo);


-- ========================================
-- 🚀 INDICE PARA TABLA: TEmpleado
-- ========================================
IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_TEmpleado_idEmpleado' AND object_id = OBJECT_ID('TEmpleado')
)
CREATE NONCLUSTERED INDEX IX_TEmpleado_idEmpleado ON TEmpleado(idEmpleado);

GO

------------------ VISTAS ----------------------------

CREATE OR ALTER VIEW vwProductosPorOrden AS
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

CREATE OR ALTER VIEW vwProductosPorOrden AS
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

-----------------  PROCEDIMIENTOS -------------------

CREATE OR ALTER PROCEDURE dbo.PReporte_Semanal
    @Modo INT,
    @FechaIni DATE,
    @FechaFin DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        --id,
        FechaVenta,
        IdOrden,
        SubTotal,
        Descuento,
        Total,
        -- Puedes calcular porcentaje si lo necesitas:
        CAST((Descuento * 100.0) / NULLIF(SubTotal, 0) AS DECIMAL(5,2)) AS Porc_Descuento,
        FechaPago,
        MontoAbonado,
        Anticipo,
        TipoPago,
        Apartado,
        Concepto,
        Asesor,
        Optometrista,
        Gerente,
        Marketing
        --Modo,
        --FechaActualizacion
    FROM dbo.PagosConConceptoMaterializado
    WHERE Modo = @Modo
      AND FechaPago >= @FechaIni AND FechaPago < DATEADD(DAY, 1, @FechaFin)
    ORDER BY IdOrden, NumPago
END;


-- FORMA DE USO EN LA APP
--EXEC PReporte_Semanal 1, '01/06/2025', '30/07/2025'; -- para óptica
--EXEC PReporte_Semanal 0, '01/05/2025', '30/07/2025'; -- para móvil

GO

CREATE OR ALTER PROCEDURE dbo.PReporte_TipoPagos
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT  -- 0 = móvil, 1 = óptica
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        TipoPago,
        COUNT(*) AS CantidadMovimientos,
        SUM(MontoAbonado) AS TotalPorTipoPago
    FROM dbo.PagosConConceptoMaterializado
    WHERE FechaPago >= @FechaIni AND FechaPago < DATEADD(DAY, 1, @FechaFin)
      AND Modo = @Modo
    GROUP BY TipoPago
    ORDER BY TotalPorTipoPago DESC;
END;


--COMO SE UTILIZA EN LA APP
--EXEC PReporte_TipoPagos '01/05/2025', '30/07/2025', 0; -- Para móvil
--EXEC PReporte_TipoPagos '01/05/2025', '30/07/2025', 1; -- Para óptica


GO

CREATE OR ALTER PROCEDURE PReporte_Concepto
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT  -- 0 = móvil, 1 = óptica
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Concepto,
        COUNT(*) AS TotalPagos,
        SUM(MontoAbonado) AS MontoTotal
    FROM dbo.PagosConConceptoMaterializado P
    WHERE P.FechaPago >= @FechaIni AND P.FechaPago < DATEADD(DAY, 1, @FechaFin)
      AND P.Modo = @Modo
    GROUP BY Concepto
    ORDER BY MontoTotal DESC;
END

--COMO SE UTILIZA EN LA APP
--EXEC PReporte_Concepto '01/05/2025', '30/07/2025', 0; -- Para móvil
--EXEC PReporte_Concepto '01/05/2025', '30/07/2025', 1; -- Para óptica

GO

CREATE OR ALTER PROCEDURE dbo.RefrescarPagosConConcepto
    @Modo INT,
    @Desde DATE,
    @Hasta DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        O.FechaOrden AS FechaVenta,
        O.idOrden AS IdOrden,
        O.SubTotal,
        O.Descuento,
        O.Total,
        PC.Porcentaje AS Anticipo,         -- % de avance del pago
        F.FechaPago,
        F.Monto AS MontoAbonado,           -- Monto monetario abonado
        PC.Porcentaje,
        T.Nombre AS TipoPago,
        PC.Apartado,
        PC.Concepto,
        PC.NumPago,                        -- ✅ nuevo campo para trazabilidad
        EA.Nombre AS Asesor,
        EG.Nombre AS Gerente,
        EO.Nombre AS Optometrista,
        EM.Nombre AS Marketing,
        @Modo AS Modo,
        GETDATE() AS FechaActualizacion
    INTO #PagosTemp
    FROM fnPagosConConcepto(@Modo, @Desde, @Hasta) PC
    INNER JOIN TFormaPago F ON F.id = PC.id
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    INNER JOIN TTipoPago T ON F.idTipoPago = T.id
    LEFT JOIN TEmpleado EA ON EA.idEmpleado = O.idAsesor
    LEFT JOIN TEmpleado EG ON EG.idEmpleado = O.idGerente
    LEFT JOIN TEmpleado EO ON EO.idEmpleado = O.idOpto
    LEFT JOIN TEmpleado EM ON EM.idEmpleado = O.idMarketing;

    CREATE CLUSTERED INDEX IX_PagosTemp_IdOrden ON #PagosTemp(IdOrden);

    MERGE dbo.PagosConConceptoMaterializado AS Target
    USING #PagosTemp AS Source
    ON Target.IdOrden = Source.IdOrden 
       AND Target.Concepto = Source.Concepto 
       AND Target.Modo = Source.Modo
    WHEN NOT MATCHED BY TARGET THEN
        INSERT (
            FechaVenta,
            IdOrden,
            SubTotal,
            Descuento,
            Total,
            Porcentaje,
            FechaPago,
            MontoAbonado,
            Anticipo,
            TipoPago,
            Apartado,
            Concepto,
            NumPago,                       -- ✅ insertado aquí también
            Asesor,
            Optometrista,
            Gerente,
            Marketing,
            Modo,
            FechaActualizacion
        )
        VALUES (
            Source.FechaVenta,
            Source.IdOrden,
            Source.SubTotal,
            Source.Descuento,
            Source.Total,
            Source.Porcentaje,
            Source.FechaPago,
            Source.MontoAbonado,
            Source.Anticipo,
            Source.TipoPago,
            Source.Apartado,
            Source.Concepto,
            Source.NumPago,
            Source.Asesor,
            Source.Optometrista,
            Source.Gerente,
            Source.Marketing,
            Source.Modo,
            Source.FechaActualizacion
        );

    DROP TABLE #PagosTemp;
END;



--EXEC dbo.RefrescarPagosConConcepto 1, '01/09/2024','30/07/2025';

GO

CREATE OR ALTER PROCEDURE PReporte_ConceptoTotalVentas
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT  -- 0 = móvil (Marketing ≠ ''), 1 = óptica (Marketing = '')
AS
BEGIN
    SET NOCOUNT ON;

    -- Fuente única y canal diferenciado por @Modo
    WITH Pagos AS (
        SELECT * 
        FROM PagosConConceptoMaterializado
        WHERE FechaPago >= @FechaIni AND FechaPago < DATEADD(DAY, 1, @FechaFin)
          AND (
                (@Modo = 1 AND LTRIM(RTRIM(ISNULL(Marketing, ''))) = '')     -- Óptica
             OR (@Modo = 0 AND LTRIM(RTRIM(ISNULL(Marketing, ''))) <> '')   -- Móvil
          )
    )

    -- 1. Venta al 100% (Contado)
    SELECT 'Venta al 100% (Contado)' AS Categoria,
           COUNT(DISTINCT P.idOrden) AS TotalOrdenes,
           SUM(P.Total) AS MontoTotal
    FROM Pagos P
    WHERE Concepto = 'Venta'
      AND NOT EXISTS (
          SELECT 1 FROM Pagos X
          WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Apartado', 'Abono', 'Retiro')
      )
      AND (SELECT COUNT(*) FROM Pagos X WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta') = 1

    UNION ALL

    -- 2. Apartado → Venta (sin retiro)
    SELECT 'Apartado → Venta',
           COUNT(DISTINCT P.idOrden),
           SUM(P.Total)
    FROM Pagos P
    WHERE Concepto = 'Apartado'
      AND EXISTS (SELECT 1 FROM Pagos X WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta')
      AND NOT EXISTS (SELECT 1 FROM Pagos Y WHERE Y.idOrden = P.idOrden AND Y.Concepto = 'Retiro')

    UNION ALL

    -- 3. Apartado → Venta → Retiro
    SELECT 'Apartado → Venta → Retiro',
           COUNT(DISTINCT P.idOrden),
           SUM(P.Total)
    FROM Pagos P
    WHERE Concepto = 'Apartado'
      AND EXISTS (SELECT 1 FROM Pagos X WHERE X.idOrden = P.idOrden AND X.Concepto = 'Venta')
      AND EXISTS (SELECT 1 FROM Pagos Y WHERE Y.idOrden = P.idOrden AND Y.Concepto = 'Retiro')

    UNION ALL

    -- 4. Apartado Periodo
    SELECT 'Apartado Periodo',
           COUNT(DISTINCT P.idOrden),
           SUM(P.Total)
    FROM Pagos P
    WHERE Concepto = 'Apartado'
      AND NOT EXISTS (
          SELECT 1 FROM Pagos X WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Venta', 'Retiro')
      )

    UNION ALL

    -- 5. Apartado Real
    SELECT 'Apartado Real',
           COUNT(DISTINCT P.idOrden),
           SUM(P.Total)
    FROM Pagos P
    WHERE Concepto = 'Apartado'
      AND NOT EXISTS (
          SELECT 1 FROM Pagos X WHERE X.idOrden = P.idOrden AND X.Concepto IN ('Venta', 'Retiro')
      )

    UNION ALL

    -- 6. Orden completada y retirada
    SELECT 'Orden completada y retirada',
           COUNT(DISTINCT P.idOrden),
           SUM(P.Total)
    FROM Pagos P
    WHERE Concepto = 'Retiro'

    UNION ALL

    -- 7. Venta (Crédito)
    SELECT 'Venta (Crédito)',
           COUNT(DISTINCT P.idOrden),
           SUM(P.Total)
    FROM Pagos P
    WHERE Concepto = 'Venta'

    UNION ALL

    -- 8. Apartado no completado (2 pagos)
    SELECT 'Apartado no completado (2 pagos)',
           COUNT(*) AS TotalOrdenes,
           SUM(Total) AS MontoTotal
    FROM (
        SELECT idOrden, SUM(Total) AS Total
        FROM Pagos
        WHERE Concepto = 'Apartado'
        GROUP BY idOrden
        HAVING COUNT(*) = 2
           AND NOT EXISTS (
               SELECT 1 FROM Pagos 
               WHERE idOrden = Pagos.idOrden AND Concepto IN ('Venta', 'Retiro')
           )
    ) AS P

    ORDER BY MontoTotal DESC;
END;

--EXEC PReporte_ConceptoTotalVentas '01/05/2025','30/07/2025', 1;

GO

--------------------- FUNCIONES ---------------------------

CREATE OR ALTER FUNCTION fnPagosConConcepto (
    @Modo INT,
    @Desde DATE,
    @Hasta DATE
)
RETURNS TABLE
AS
RETURN
WITH Umbral AS (
    SELECT CASE WHEN @Modo = 0 THEN 20.0 ELSE 40.0 END AS Valor
),
Pagos AS (
    SELECT 
        F.id,
        F.idOrden,
        F.Monto,
        F.FechaPago,
        O.Total AS MontoPagar,
        SUM(F.Monto) OVER (
            PARTITION BY F.idOrden  
            ORDER BY F.id  
            ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
        ) * 100.0 / O.Total AS Porcentaje
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    WHERE F.FechaPago >= @Desde AND F.FechaPago < DATEADD(DAY, 1, @Hasta)
      AND ISNULL(O.idMarketing, 0) = CASE 
          WHEN @Modo = 1 THEN 1
          WHEN @Modo = 0 THEN 2
      END
),
PagosPorOrden AS (
    SELECT idOrden, COUNT(*) AS TotalPagos
    FROM Pagos
    GROUP BY idOrden
),
PrimeraVenta AS (
    SELECT P.idOrden, MIN(P.id) AS idVenta
    FROM Pagos P
    CROSS JOIN Umbral U
    WHERE P.Porcentaje >= U.Valor AND P.Porcentaje < 100
    GROUP BY P.idOrden
),
VentaPorRetiro AS (
    SELECT P.idOrden, MAX(P.id) AS idVentaFinal
    FROM Pagos P
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
    CAST(P.Porcentaje AS DECIMAL(5,2)) AS Porcentaje,
    P.FechaPago,
    CASE
        WHEN P.Porcentaje = 100 AND PPO.TotalPagos = 1 THEN 'Venta'
        WHEN P.Porcentaje = 100 AND P.id = VPR.idVentaFinal THEN 'Venta'
        WHEN P.Porcentaje = 100 THEN 'Retiro'
        WHEN P.id = PV.idVenta THEN 'Venta'
        WHEN P.Porcentaje >= U.Valor THEN 'Abono'
        WHEN P.Porcentaje < U.Valor THEN 'Apartado'
        ELSE 'N/A'
    END AS Concepto,
    CASE 
        WHEN 
            (P.Porcentaje < U.Valor  
            OR (
                P.Porcentaje = 100 AND P.id = VPR.idVentaFinal  
                AND PPO.TotalPagos > 1
                AND NOT EXISTS (
                    SELECT 1 FROM PrimeraVenta WHERE idOrden = P.idOrden
                )
            )
        ) THEN P.MontoPagar
        ELSE 0
    END AS Apartado,
    ROW_NUMBER() OVER (
        PARTITION BY P.idOrden 
        ORDER BY P.FechaPago, P.id
    ) AS NumPago,                      -- ✅ campo agregado
    @Modo AS Modo
FROM Pagos P
CROSS JOIN Umbral U
LEFT JOIN PagosPorOrden PPO ON P.idOrden = PPO.idOrden
LEFT JOIN PrimeraVenta PV ON P.idOrden = PV.idOrden
LEFT JOIN VentaPorRetiro VPR ON P.idOrden = VPR.idOrden;


GO

CREATE OR ALTER FUNCTION fnPagosDetalladosModo (
    @Modo INT
)
RETURNS TABLE
AS
RETURN
WITH BasePagos AS (
    SELECT  
        F.id AS idPago,
        F.idOrden,
        O.FechaOrden,
        O.SubTotal,
        O.Descuento,
        O.Total AS MontoPagar,
        F.FechaPago,
        F.Monto,
        T.Nombre AS TipoPago,
        PCM.Porcentaje,
        PCM.Concepto,
        PCM.Apartado,
        PCM.Modo AS ModoOrigen,
        O.idAsesor,
        O.idGerente,
        O.idOpto,
        O.idMarketing
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    INNER JOIN TTipoPago T ON F.idTipoPago = T.id
    LEFT JOIN dbo.PagosConConceptoMaterializado PCM 
        ON PCM.idOrden = F.idOrden 
        AND PCM.Modo = CAST(@Modo AS VARCHAR)
        AND PCM.Concepto IS NOT NULL
    WHERE ISNULL(O.idMarketing, 0) = CASE 
        WHEN @Modo = 1 THEN 1         -- Óptica
        WHEN @Modo = 0 THEN 2         -- Móvil
    END
),
PagosNumerados AS (
    SELECT *,
        ROW_NUMBER() OVER (PARTITION BY idOrden ORDER BY FechaPago, idPago) AS NumPago
    FROM BasePagos
)
SELECT 
    ROW_NUMBER() OVER (ORDER BY idOrden, FechaPago, idPago) AS Item,
    CAST(FechaOrden AS DATE) AS FechaVenta,
    idOrden,
    SubTotal,
    Descuento,
    MontoPagar AS Total,
    CASE WHEN SubTotal > 0 THEN (Descuento * 100.0) / SubTotal ELSE 0 END AS Descuentos,
    CAST(FechaPago AS DATE) AS FechaPago,
    Monto AS MontoAbonado,
    TipoPago,
    ISNULL(Porcentaje, 0) AS Anticipo,
    NumPago,
    Concepto,
    Apartado,
    EA.Nombre AS Asesor,
    EG.Nombre AS Gerente,
    EO.Nombre AS Optometrista,
    EM.Nombre AS Marketing,
    ModoOrigen AS Modo,
    '' AS Cobranza
FROM PagosNumerados P
LEFT JOIN TEmpleado EA ON EA.idEmpleado = P.idAsesor
LEFT JOIN TEmpleado EG ON EG.idEmpleado = P.idGerente
LEFT JOIN TEmpleado EO ON EO.idEmpleado = P.idOpto
LEFT JOIN TEmpleado EM ON EM.idEmpleado = P.idMarketing;

--EXEC fnPagosDetalladosModo 1;
GO




