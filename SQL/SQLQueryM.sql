USE BDOptica2 
GO

USE BDOptica2 
GO

--ELIMINAR TODOS LOS PROCEDIMIENTO, VISTAS Y TABLAS

DROP TABLE IF EXISTS dbo.PagosConConceptoMaterializado; 
GO


DROP FUNCTION IF EXISTS dbo.fn_CalcularConceptoPago; 
GO
DROP FUNCTION IF EXISTS dbo.fnPagosConConcepto; 
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
IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_PCM_id' AND object_id = OBJECT_ID('PagosConConceptoMaterializado')
)
CREATE CLUSTERED INDEX IX_PCM_id ON PagosConConceptoMaterializado(id);

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes 
    WHERE name = 'IX_PCM_Modo' AND object_id = OBJECT_ID('PagosConConceptoMaterializado')
)
CREATE NONCLUSTERED INDEX IX_PCM_Modo ON PagosConConceptoMaterializado(Modo);

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

-----------------  PROCEDIMIENTOS -------------------

CREATE OR ALTER PROCEDURE PReporte_Semanal
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT  -- 0 = móvil, 1 = óptica
AS
BEGIN
    SET NOCOUNT ON;

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
    FROM fnPagosDetalladosModo(@Modo) P
    WHERE P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
    ORDER BY P.idOrden;
END;

-- FORMA DE USO EN LA APP
--EXEC PReporte_Semanal '01/05/2025', '30/07/2025', 1; -- para óptica
--EXEC PReporte_Semanal '01/05/2025', '30/07/2025', 0; -- para móvil

GO

CREATE OR ALTER PROCEDURE PReporte_TipoPagos
    @FechaIni DATETIME,
    @FechaFin DATETIME,
    @Modo INT  -- 0 = móvil, 1 = óptica
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        P.TipoPago,
        COUNT(*) AS CantidadMovimientos,
        SUM(P.Monto) AS TotalPorTipoPago
    FROM fnPagosDetalladosModo(@Modo) P
    WHERE P.Fecha_Abono BETWEEN @FechaIni AND @FechaFin
    GROUP BY P.TipoPago;
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
        SUM(Monto) AS MontoTotal
    FROM dbo.PagosConConceptoMaterializado P
    WHERE P.FechaPago BETWEEN @FechaIni AND @FechaFin
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

    -------------------------------
    -- 1. Eliminación por lotes
    -------------------------------
    DECLARE @BatchSizeDelete INT = 10000;
    DECLARE @FilasEliminadas INT = 1;

    WHILE @FilasEliminadas > 0
    BEGIN
        DELETE TOP (@BatchSizeDelete)
        FROM dbo.PagosConConceptoMaterializado
        WHERE Modo = CAST(@Modo AS VARCHAR);

        SET @FilasEliminadas = @@ROWCOUNT;
    END

    -------------------------------
    -- 2. Materialización temporal
    -------------------------------
    SELECT 
        id, idOrden, Monto, MontoPagar, Porcentaje, Concepto, Apartado,
        CAST(@Modo AS VARCHAR) AS Modo,
        FechaPago
    INTO #PagosTemp
    FROM dbo.fnPagosConConcepto(@Modo, @Desde, @Hasta)
    OPTION (RECOMPILE);

    CREATE CLUSTERED INDEX IX_PagosTemp_id ON #PagosTemp(id);

    -------------------------------
    -- 3. Inserción por lotes rápida
    -------------------------------
    DECLARE @BatchSizeInsert INT = 10000;
    DECLARE @UltimoId INT = 0;
    DECLARE @FilasInsertadas INT = 1;

    WHILE @FilasInsertadas > 0
    BEGIN
        INSERT INTO dbo.PagosConConceptoMaterializado (
            id, idOrden, Monto, MontoPagar, Porcentaje, Concepto, Apartado,
            Modo, FechaPago
        )
        SELECT TOP (@BatchSizeInsert)
            id, idOrden, Monto, MontoPagar, Porcentaje, Concepto, Apartado,
            Modo, FechaPago
        FROM #PagosTemp
        WHERE id > @UltimoId
        ORDER BY id;

        SET @FilasInsertadas = @@ROWCOUNT;
        SET @UltimoId = @UltimoId + @BatchSizeInsert;
    END

    -------------------------------
    -- 4. Liberar memoria
    -------------------------------
    DROP TABLE #PagosTemp;
END;


--EXEC dbo.RefrescarPagosConConcepto 1, '01/05/2025','30/07/2025';

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
        F.Jornada,
        O.Total AS MontoPagar,
        SUM(F.Monto) OVER (
            PARTITION BY F.idOrden  
            ORDER BY F.id  
            ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW
        ) * 100.0 / O.Total AS Porcentaje
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    WHERE F.Jornada = @Modo AND F.FechaPago BETWEEN @Desde AND @Hasta
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
    P.Jornada
FROM Pagos P
CROSS JOIN Umbral U
LEFT JOIN PagosPorOrden PPO ON P.idOrden = PPO.idOrden
LEFT JOIN PrimeraVenta PV ON P.idOrden = PV.idOrden
LEFT JOIN VentaPorRetiro VPR ON P.idOrden = VPR.idOrden
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
        PCM.Apartado,
        PCM.Modo AS ModoOrigen
    FROM TFormaPago F
    INNER JOIN TOrden O ON F.idOrden = O.idOrden
    INNER JOIN TTipoPago T ON F.idTipoPago = T.id
    LEFT JOIN dbo.PagosConConceptoMaterializado PCM 
        ON PCM.id = F.id AND PCM.Modo = @Modo
    WHERE ISNULL(O.idMarketing, 0) = CASE 
        WHEN @Modo = 1 THEN 1         -- Óptica
        WHEN @Modo = 0 THEN 2         -- Móvil (puedes ajustar si hay más valores mayores a 1)
    END
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




