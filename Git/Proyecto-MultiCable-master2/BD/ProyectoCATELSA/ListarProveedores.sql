CREATE PROCEDURE LISTARPROVEEDORES
AS
BEGIN
SELECT [IDProveedor]
      ,[NombreProveedor]
      ,[RTN]
      ,[PersonaContacto]
      ,[Direccion]
      ,[Pais_Zona]
      ,[Tipo_Proveedor]
      ,[Num_Telefono]
      ,[CorreoElectronico]
      ,[Notas]
      ,[Activo]
  FROM [dbo].[Proveedores]
END
