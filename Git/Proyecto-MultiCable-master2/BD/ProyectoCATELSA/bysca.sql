USE [CATELSA-MULTICABLE]
GO

/****** Object:  StoredProcedure [dbo].[BuscarProveedorPorNombre]    Script Date: 28/5/2023 20:55:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[BuscarProveedorPorNombre]
    @NombreProveedor nvarchar(50)
AS
BEGIN
    SELECT *
    FROM Proveedores
    WHERE NombreProveedor = @NombreProveedor
END
GO


