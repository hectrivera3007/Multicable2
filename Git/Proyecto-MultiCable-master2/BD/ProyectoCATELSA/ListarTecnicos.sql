CREATE PROCEDURE LISTARTECNICOS
AS
BEGIN
SELECT [IDSolicitante]
      ,[FechaRegistro]
      ,[Nombres]
      ,[Apellidos]
      ,[DNI]
      ,[Direccion]
      ,[Num_Telefono]
      ,[Notas]
      ,[RequisaID]
      ,[Activo]
  FROM [dbo].[RegistrarTecnicos]
END