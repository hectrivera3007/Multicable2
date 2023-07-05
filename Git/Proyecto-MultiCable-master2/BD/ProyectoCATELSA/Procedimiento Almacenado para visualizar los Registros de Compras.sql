CREATE PROCEDURE ObtenerComprasConProveedores
AS
BEGIN
    SELECT dbo.Compras.IDCompra AS ID, dbo.Compras.Fecha AS Fecha, dbo.Compras.Codigo AS C�digo, dbo.Compras.Producto AS Producto, dbo.Compras.Cantidad AS Cantidad, dbo.Compras.PrecioUnitarioCompraDolares AS [Precio en D�lares], dbo.Compras.CostFOBDolares AS [Costo FOB D�lares],
           dbo.Compras.CostosDeTransporte AS [Costos de Transporte], dbo.Compras.CostoCIFDolares AS [Costo CIF D�lares], dbo.Compras.CostoCIFLempiras AS [Costo CIF Lempiras], dbo.Compras.CostosDeImportacion AS [Costos de Importaci�n], dbo.Compras.CostoTotalCompraLempiras AS [Total Lempiras], dbo.Compras.CostoTotalCompraDolares AS [Total D�lares],
           dbo.Proveedores.NombreProveedor AS [Nombre Proveedor], dbo.Compras.Activo AS Activo
    FROM dbo.Compras
    INNER JOIN dbo.Proveedores ON dbo.Compras.IDProveedor = dbo.Proveedores.IDProveedor
END
