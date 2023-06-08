USE [CATELSA-MULTICABLE]
GO

INSERT INTO [dbo].[Usuario]
           ([Nombre]
           ,[NombreUsuario]
           ,[NumTelefono]
           ,[Contrasena]
           ,[ConfirmarContrasena]
           ,[RolID]
           ,[BodegaID]
           ,[Activo])
     VALUES
           (<Nombre, varchar(50),>
           ,<NombreUsuario, varchar(50),>
           ,<NumTelefono, varchar(50),>
           ,<Contrasena, varchar(50),>
           ,<ConfirmarContrasena, varchar(50),>
           ,<RolID, int,>
           ,<BodegaID, int,>
           ,<Activo, bit,>)
GO


