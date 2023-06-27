CREATE PROCEDURE NumerodeOrden
AS
BEGIN
    DECLARE @NumOrden INT
    SELECT @NumOrden = COALESCE(MAX(NumOrden), 0) + 1 FROM Compras
    INSERT INTO Compras (NumOrden, Fecha) VALUES (@NumOrden, GETDATE())
    SELECT @NumOrden AS Numero_Orden_Generado
END


CREATE PROCEDURE BuscarProveedorPorNombre
    @NombreProveedor nvarchar(50)
AS
BEGIN
    SELECT *
    FROM Proveedores
    WHERE NombreProveedor = @NombreProveedor
END

exec BuscarProveedorPorNombre CaribeComp;




CREATE PROCEDURE BuscarUsuariosProc
@Nombre NVARCHAR(100)
AS
BEGIN 
SET NOCOUNT ON; 
SELECT * FROM VistaUsuario WHERE Nombre LIKE '%' + @Nombre + '%'
END



EXEC VistaUsuario