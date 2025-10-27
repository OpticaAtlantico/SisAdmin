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
    O.idMarketing, 

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

--SELECT * FROM vwProductosPorOrden

GO

-----------------  PROCEDIMIENTOS -------------------

CREATE OR ALTER PROCEDURE dbo.PReporte_Semanal
    @FechaIni DATE,
    @FechaFin DATE,
    @Modo INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        FechaVenta,
        IdOrden,
        SubTotal,
        Descuento,
        Total,
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
    FROM dbo.PagosConConceptoMaterializado
    WHERE Modo = @Modo
      AND FechaPago >= @FechaIni
      AND FechaPago < DATEADD(DAY, 1, @FechaFin)
    ORDER BY IdOrden, NumPago;
END;



-- FORMA DE USO EN LA APP
--EXEC PReporte_Semanal '01/06/2025', '30/09/2025', 1; -- para óptica
--EXEC PReporte_Semanal 0, '01/05/2025', '30/07/2025'; -- para móvil

GO

CREATE OR ALTER PROCEDURE dbo.PReporte_TipoPagos
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Consulta unificada con UNION ALL
    SELECT 
        TipoPago,
        CantidadMovimientos,
        TotalPorTipoPago
    FROM
    (
        -- Resultados por TipoPago
        SELECT
            TipoPago,
            COUNT(*) AS CantidadMovimientos,
            SUM(MontoAbonado) AS TotalPorTipoPago,
            0 AS EsTotal
        FROM dbo.PagosConConceptoMaterializado
        WHERE FechaPago >= @FechaIni
          AND FechaPago < DATEADD(DAY, 1, @FechaFin)
          AND Modo = @Modo
        GROUP BY TipoPago

        UNION ALL

        -- Total general
        SELECT
            'TOTAL GENERAL' AS TipoPago,
            COUNT(*) AS CantidadMovimientos,
            SUM(MontoAbonado) AS TotalPorTipoPago,
            1 AS EsTotal
        FROM dbo.PagosConConceptoMaterializado
        WHERE FechaPago >= @FechaIni
          AND FechaPago < DATEADD(DAY, 1, @FechaFin)
          AND Modo = @Modo
    ) AS T
    ORDER BY 
        T.EsTotal, 
        T.TotalPorTipoPago DESC;
END;

--COMO SE UTILIZA EN LA APP
--EXEC PReporte_TipoPagos '01/05/2025', '30/07/2025', 0; -- Para móvil
--EXEC PReporte_TipoPagos '01/05/2025', '30/07/2025', 1; -- Para óptica


GO

CREATE OR ALTER PROCEDURE dbo.PReporte_Concepto
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Reporte por concepto
    SELECT 
        Concepto,
        COUNT(*) AS TotalPagos,
        SUM(MontoAbonado) AS MontoTotal
    FROM dbo.PagosConConceptoMaterializado
    WHERE FechaPago >= @FechaIni
      AND FechaPago < DATEADD(DAY, 1, @FechaFin)
      AND Modo = @Modo
    GROUP BY Concepto

    UNION ALL

    -- Total general
    SELECT 
        'TOTAL GENERAL',
        COUNT(*),
        SUM(MontoAbonado)
    FROM dbo.PagosConConceptoMaterializado
    WHERE FechaPago >= @FechaIni
      AND FechaPago < DATEADD(DAY, 1, @FechaFin)
      AND Modo = @Modo

    ORDER BY 3 DESC; -- ordena por MontoTotal
END;


--COMO SE UTILIZA EN LA APP
--EXEC PReporte_Concepto '01/05/2025', '30/07/2025', 0; -- Para móvil
--EXEC PReporte_Concepto '01/05/2025', '30/07/2025', 1; -- Para óptica

GO

CREATE OR ALTER PROCEDURE dbo.RefrescarPagosConConcepto
    @Desde DATE,
    @Hasta DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Armar dataset temporal con todos los pagos del rango
    SELECT 
        O.FechaOrden AS FechaVenta,
        O.idOrden AS IdOrden,
        O.SubTotal,
        O.Descuento,
        O.Total,
        PC.Porcentaje AS Anticipo,
        F.FechaPago,
        F.Monto AS MontoAbonado,
        PC.Porcentaje,
        T.Nombre AS TipoPago,
        PC.Apartado,
        PC.Concepto,
        PC.NumPago,
        EA.Nombre AS Asesor,
        EG.Nombre AS Gerente,
        EO.Nombre AS Optometrista,
        EM.Nombre AS Marketing,
        PC.Modo,
        GETDATE() AS FechaActualizacion
    INTO #PagosTemp
    FROM dbo.fnPagosConConcepto() PC
    INNER JOIN TFormaPago F ON F.id = PC.id
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    INNER JOIN TTipoPago T ON F.idTipoPago = T.id
    LEFT JOIN TEmpleado EA ON EA.idEmpleado = O.idAsesor
    LEFT JOIN TEmpleado EG ON EG.idEmpleado = O.idGerente
    LEFT JOIN TEmpleado EO ON EO.idEmpleado = O.idOpto
    LEFT JOIN TEmpleado EM ON EM.idEmpleado = O.idMarketing
    WHERE F.FechaPago >= @Desde AND F.FechaPago < DATEADD(DAY, 1, @Hasta);

    -- 2. Índice en temp para acelerar el MERGE
    CREATE CLUSTERED INDEX IX_PagosTemp ON #PagosTemp(IdOrden, Concepto, Modo, NumPago, FechaPago);

    -- 3. MERGE ajustado
    MERGE dbo.PagosConConceptoMaterializado AS Target
    USING #PagosTemp AS Source
    ON Target.IdOrden     = Source.IdOrden 
       AND Target.Concepto = Source.Concepto 
       AND Target.Modo     = Source.Modo
       AND Target.NumPago  = Source.NumPago
       AND Target.FechaPago = Source.FechaPago
    WHEN MATCHED THEN
        UPDATE SET
            Target.MontoAbonado       = Source.MontoAbonado,
            Target.Porcentaje         = Source.Porcentaje,
            Target.Anticipo           = Source.Anticipo,
            Target.TipoPago           = Source.TipoPago,
            Target.Apartado           = Source.Apartado,
            Target.Asesor             = Source.Asesor,
            Target.Optometrista       = Source.Optometrista,
            Target.Gerente            = Source.Gerente,
            Target.Marketing          = Source.Marketing,
            Target.FechaActualizacion = GETDATE()
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
            NumPago,
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
            GETDATE()
        );

    DROP TABLE #PagosTemp;
END;

GO

--EXEC dbo.RefrescarPagosConConcepto '01/09/2024','30/09/2025';

CREATE OR ALTER PROCEDURE dbo.PReporte_ConceptoTotalVentas
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT,
    @UmbralAnticipo INT = 40
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH OrdersInRange AS (
        SELECT DISTINCT idOrden
        FROM dbo.PagosConConceptoMaterializado
        WHERE FechaPago >= @FechaIni
          AND FechaPago < DATEADD(DAY, 1, @FechaFin)
          AND Modo = @Modo
    ),
    PagosOrdenes AS (
        SELECT p.*
        FROM dbo.PagosConConceptoMaterializado p
        INNER JOIN OrdersInRange r ON p.idOrden = r.idOrden
        WHERE p.Modo = @Modo
    ),
    ConversionVenta AS (
        SELECT 
            idOrden,
            MIN(FechaPago) AS FechaConversion
        FROM (
            SELECT 
                p.idOrden,
                p.FechaPago,
                SUM(p.Total) OVER (PARTITION BY p.idOrden ORDER BY p.FechaPago ROWS UNBOUNDED PRECEDING) AS Acumulado,
                SUM(p.Total) OVER (PARTITION BY p.idOrden) AS TotalOrden
            FROM PagosOrdenes p
        ) t
        WHERE Acumulado >= TotalOrden * @UmbralAnticipo / 100
        GROUP BY idOrden
    ),
    OrdenesAgrupadas AS (
        SELECT 
            idOrden,
            MIN(FechaVenta) AS FechaVenta,
            MIN(FechaPago) AS FechaPrimerPago,
            MAX(FechaPago) AS UltFechaPago,
            COUNT(*) AS TotalPagos,
            COUNT(CASE WHEN Concepto = 'Venta' THEN 1 END) AS CantVenta,
            COUNT(CASE WHEN Concepto = 'Apartado' THEN 1 END) AS CantApartado,
            COUNT(CASE WHEN Concepto = 'Retiro' THEN 1 END) AS CantRetiro,
            SUM(CASE WHEN Concepto = 'Venta' THEN Total ELSE 0 END) AS MontoVenta,
            SUM(CASE WHEN Concepto = 'Apartado' THEN Total ELSE 0 END) AS MontoApartado,
            SUM(Total) AS MontoPagado,
            MAX(CASE WHEN Concepto = 'Venta' THEN Anticipo ELSE NULL END) AS AnticipoVenta,
            AVG(CASE WHEN Concepto = 'Apartado' THEN Anticipo ELSE NULL END) AS AnticipoApartado,
            MAX(CASE WHEN Concepto = 'Venta' AND FechaPago >= @FechaIni AND FechaPago < DATEADD(DAY,1,@FechaFin) THEN 1 ELSE 0 END) AS HasVentaEnPeriodo,
            MAX(CASE WHEN FechaPago >= @FechaIni AND FechaPago < DATEADD(DAY,1,@FechaFin) THEN 1 ELSE 0 END) AS HasPagoEnPeriodo
        FROM PagosOrdenes
        GROUP BY idOrden
    ),
    ClasificacionOrbital AS (
        SELECT 
            o.idOrden,
            o.MontoPagado,
            o.MontoVenta,
            o.MontoApartado,
            o.FechaVenta,
            o.FechaPrimerPago,
            o.CantVenta,
            o.CantApartado,
            o.CantRetiro,
            o.AnticipoVenta,
            o.AnticipoApartado,
            o.HasVentaEnPeriodo,
            o.HasPagoEnPeriodo,
            c.FechaConversion,
            CASE
                WHEN TotalPagos = 1 AND CantVenta = 1 AND AnticipoVenta = 100
                     AND (CAST(FechaVenta AS DATE) = CAST(FechaPrimerPago AS DATE) OR HasVentaEnPeriodo = 1)
                THEN 'Venta al 100% (Contado)'
                WHEN CantApartado > 0 AND CantVenta > 0 AND CantRetiro = 0
                     AND CAST(FechaVenta AS DATE) = CAST(FechaPrimerPago AS DATE)
                THEN 'Apartado → Venta (sin retiro, misma fecha)'
                WHEN CantApartado > 0 AND CantVenta > 0 AND CantRetiro = 0
                     AND (HasVentaEnPeriodo = 1 OR (CAST(FechaVenta AS DATE) <> CAST(FechaPrimerPago AS DATE) AND HasPagoEnPeriodo = 1))
                THEN 'Apartado → Venta (sin retiro, abono posterior)'
                WHEN CantApartado > 0 AND CantVenta > 0 AND CantRetiro > 0
                     AND CAST(FechaVenta AS DATE) = CAST(FechaPrimerPago AS DATE)
                THEN 'Apartado → Venta → Retiro (misma fecha)'
                WHEN CantApartado > 0 AND CantVenta > 0 AND CantRetiro > 0
                     AND (HasVentaEnPeriodo = 1 OR (CAST(FechaVenta AS DATE) <> CAST(FechaPrimerPago AS DATE) AND HasPagoEnPeriodo = 1))
                THEN 'Apartado → Venta → Retiro (fecha distinta)'
                WHEN CantApartado > 0 AND CantVenta = 0 AND CantRetiro = 0 AND ISNULL(AnticipoApartado,0) < @UmbralAnticipo
                THEN 'Apartado vigente (sin Venta ni Retiro)'
                WHEN CantVenta > 0 AND AnticipoVenta < 100
                     AND (HasVentaEnPeriodo = 1 OR (FechaConversion BETWEEN @FechaIni AND @FechaFin))
                THEN 'Venta (Crédito)'
                WHEN CantApartado >= 2 AND CantVenta = 0 AND CantRetiro = 0 AND HasPagoEnPeriodo = 1
                THEN 'Apartado no completado (2 pagos)'
                ELSE 'Sin clasificar'
            END AS EstadoOrbital
        FROM OrdenesAgrupadas o
        LEFT JOIN ConversionVenta c ON o.idOrden = c.idOrden
    )

    -- Reporte final
    SELECT EstadoOrbital AS Categoria,
           COUNT(*) AS TotalOrdenes,
           SUM(CASE 
                   WHEN EstadoOrbital IN (
                       'Venta al 100% (Contado)',
                       'Venta (Crédito)',
                       'Apartado → Venta (sin retiro, misma fecha)',
                       'Apartado → Venta (sin retiro, abono posterior)',
                       'Apartado → Venta → Retiro (misma fecha)',
                       'Apartado → Venta → Retiro (fecha distinta)'
                   ) THEN ISNULL(MontoVenta,0)
                   WHEN EstadoOrbital LIKE 'Apartado%' THEN ISNULL(MontoApartado,0)
                   ELSE ISNULL(MontoPagado,0)
               END) AS MontoTotal
    FROM ClasificacionOrbital
    WHERE EstadoOrbital <> 'Sin clasificar'
    GROUP BY EstadoOrbital

    UNION ALL
    SELECT 'TOTAL GENERAL',
           COUNT(*),
           SUM(CASE 
                   WHEN EstadoOrbital IN (
                       'Venta al 100% (Contado)',
                       'Venta (Crédito)',
                       'Apartado → Venta (sin retiro, misma fecha)',
                       'Apartado → Venta (sin retiro, abono posterior)',
                       'Apartado → Venta → Retiro (misma fecha)',
                       'Apartado → Venta → Retiro (fecha distinta)'
                   ) THEN ISNULL(MontoVenta,0)
                   WHEN EstadoOrbital LIKE 'Apartado%' THEN ISNULL(MontoApartado,0)
                   ELSE ISNULL(MontoPagado,0)
               END)
    FROM ClasificacionOrbital
    WHERE EstadoOrbital IN (
        'Venta al 100% (Contado)',
        'Venta (Crédito)',
        'Apartado → Venta (sin retiro, misma fecha)',
        'Apartado → Venta (sin retiro, abono posterior)',
        'Apartado → Venta → Retiro (misma fecha)',
        'Apartado → Venta → Retiro (fecha distinta)'
    )
    ORDER BY 3 DESC; -- usa la posición de columna (MontoTotal)
END;

--EXEC PReporte_ConceptoTotalVentas '18/09/2025','18/09/2025', 1;

GO

CREATE OR ALTER PROCEDURE dbo.spInicializarPagosDiaInteligente
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FechaInicioSistema DATE = '2025-01-01';
    DECLARE @FechaActual DATE = CAST(GETDATE() AS DATE);
    DECLARE @Desde DATE;
    DECLARE @Hasta DATE = @FechaActual;
    DECLARE @Existentes INT;

    -- Verifica si hay registros en la tabla materializada
    SELECT @Existentes = COUNT(*) 
    FROM dbo.PagosConConceptoMaterializado;

    IF @Existentes = 0
    BEGIN
        PRINT '🟢 Tabla vacía. Cargando desde fecha inicio del sistema.';
        SET @Desde = @FechaInicioSistema;
    END
    ELSE
    BEGIN
        -- Refrescar últimos 7 días para cubrir cambios atrasados
        SET @Desde = DATEADD(DAY, -7, @FechaActual);

        PRINT '🟡 Tabla contiene datos. Se refrescarán los últimos 7 días: '
              + CONVERT(VARCHAR(10), @Desde, 120) 
              + ' hasta ' 
              + CONVERT(VARCHAR(10), @Hasta, 120);
    END

    -- Ejecutar refresco con el rango definido
    EXEC dbo.RefrescarPagosConConcepto 
         @Desde = @Desde, 
         @Hasta = @Hasta;
END;

GO

--CREATE OR ALTER TRIGGER trg_Pagos_UpdateMaterializado
--ON dbo.TFormaPago
--AFTER INSERT, UPDATE, DELETE
--AS
--BEGIN
--    SET NOCOUNT ON;

--    -- INSERTADOS O ACTUALIZADOS
--    MERGE dbo.PagosConConceptoMaterializado AS target
--    USING (
--        SELECT 
--            p.PagoID,
--            p.OrdenID,
--            p.Monto,
--            p.FechaPago,
--            o.ClienteID,
--            o.TotalOrden
--        FROM inserted p
--        INNER JOIN dbo.TOrdenes o ON p.OrdenID = o.OrdenID
--    ) AS src
--    ON target.PagoID = src.PagoID
--    WHEN MATCHED THEN 
--        UPDATE SET 
--            target.Monto = src.Monto,
--            target.FechaPago = src.FechaPago,
--            target.ClienteID = src.ClienteID,
--            target.TotalOrden = src.TotalOrden
--    WHEN NOT MATCHED BY TARGET THEN
--        INSERT (PagoID, OrdenID, Monto, FechaPago, ClienteID, TotalOrden)
--        VALUES (src.PagoID, src.OrdenID, src.Monto, src.FechaPago, src.ClienteID, src.TotalOrden)
--    WHEN NOT MATCHED BY SOURCE 
--         AND target.PagoID IN (SELECT PagoID FROM deleted)
--        THEN DELETE;
--END;

--GO

CREATE OR ALTER PROCEDURE dbo.PReporte_Productos
    @FechaIni DATE,
    @FechaFin DATE,
    @Modo INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM vwProductosPorOrden V
    WHERE V.FechaPago  >= @FechaIni
      AND V.FechaPago < DATEADD(DAY, 1, @FechaFin)
      AND (
            (@Modo = 1 AND ISNULL(V.idMarketing, 0) = 1)     -- Óptica
         OR (@Modo = -1 AND ISNULL(V.idMarketing, 0) > 1)     -- Móvil
      )
    ORDER BY V.idOrden;
END;

GO
--------------------- FUNCIONES ---------------------------

CREATE OR ALTER FUNCTION dbo.fnPagosConConcepto()
RETURNS TABLE
AS
RETURN
WITH Pagos AS (
    SELECT 
        F.id,
        F.idOrden,
        F.Monto,
        F.FechaPago,
        O.Total AS MontoPagar,
        ISNULL(O.idMarketing, 0) AS idMarketing,
        SUM(F.Monto) OVER (
            PARTITION BY F.idOrden ORDER BY F.id
            ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
        ) * 100.0 / O.Total AS Porcentaje,
        CASE 
            WHEN ISNULL(O.idMarketing, 0) = 2 THEN 0  -- móvil
            WHEN ISNULL(O.idMarketing, 0) = 1 THEN 1  -- óptica
            ELSE -1
        END AS Modo
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    WHERE F.FechaPago IS NOT NULL
),
PagosPorOrden AS (
    SELECT idOrden, COUNT(*) AS TotalPagos
    FROM Pagos
    GROUP BY idOrden
),
PrimeraVenta AS (
    SELECT P.idOrden, MIN(P.id) AS idVenta
    FROM Pagos P
    WHERE P.Porcentaje >= CASE WHEN P.Modo = 0 THEN 20.0 ELSE 40.0 END
          AND P.Porcentaje < 100
    GROUP BY P.idOrden
),
VentaPorRetiro AS (
    SELECT P.idOrden, MAX(P.id) AS idVentaFinal
    FROM Pagos P
    WHERE P.Porcentaje = 100
      AND P.idOrden NOT IN (SELECT idOrden FROM PrimeraVenta)
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
        WHEN P.Porcentaje >= CASE WHEN P.Modo = 0 THEN 20.0 ELSE 40.0 END THEN 'Abono'
        ELSE 'Apartado'
    END AS Concepto,
    CASE 
        WHEN 
            (P.Porcentaje < CASE WHEN P.Modo = 0 THEN 20.0 ELSE 40.0 END  
            OR (
                P.Porcentaje = 100 AND P.id = VPR.idVentaFinal  
                AND PPO.TotalPagos > 1
                AND NOT EXISTS (SELECT 1 FROM PrimeraVenta WHERE idOrden = P.idOrden)
            )) THEN P.MontoPagar
        ELSE 0
    END AS Apartado,
    ROW_NUMBER() OVER (
        PARTITION BY P.idOrden 
        ORDER BY P.FechaPago, P.id
    ) AS NumPago,
    P.Modo
FROM Pagos P
LEFT JOIN PagosPorOrden PPO ON P.idOrden = PPO.idOrden
LEFT JOIN PrimeraVenta PV ON P.idOrden = PV.idOrden
LEFT JOIN VentaPorRetiro VPR ON P.idOrden = VPR.idOrden;



--EXEC PReporte_Semanal '01/09/2024', '30/09/2025', 1;
--EXEC PReporte_TipoPagos '01/05/2025', '30/07/2025', 1;
--EXEC PReporte_Concepto '01/05/2025', '30/07/2025', 1;
--EXEC PReporte_ConceptoTotalVentas '01/05/2025','30/07/2025', 1;
--EXEC PReporte_Productos '01/05/2025','30/07/2025', 1;

