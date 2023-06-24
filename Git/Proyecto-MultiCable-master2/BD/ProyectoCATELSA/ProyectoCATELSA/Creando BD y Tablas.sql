/*Creación de la Base de Datos*/
CREATE DATABASE "CATELSA-MULTICABLE"
USE [CATELSA-MULTICABLE]

--DBCC CHECKIDENT ('Usuario', RESEED, 0);

--Creación de la tabla Roles
Create Table Rol
(
	RolID int IDENTITY(1,1) not null,
	RolName varchar(50)UNIQUE,
	Activo bit DEFAULT 1
	Primary Key (RolID),
);

--UPDATE Usuario SET Nombre = @Nombre, NombreUsuario = @NombreUsuario, NumTelefono = @NumTelefono, Contrasena = @Contrasena,
--ConfirmarContrasena = @ConfirmarContrasena, RolID = @RolID, BodegaID = @BodegaID, Activo = @Activo
--WHERE (ID = @Original_ID)

Select Max(ID)+1 FROM Usuario

select * from Vista_Usuarios

Select * From Usuario

/*Creación de la tabla de Bodega*/
Create Table Bodega
(
	BodegaID int IDENTITY(1,1),
	Nombre varchar(50),
	Activo bit DEFAULT 1,
	Primary Key(BodegaID)
);

--Creación de la tabla de Usuario
Create Table Usuario
(
	ID int IDENTITY(1,1) not null,
	Nombre varchar(50),
	NombreUsuario varchar(50),
	NumTelefono varchar(50),
	Contrasena varchar(50),
	ConfirmarContrasena varchar(50),
	RolID int,
	BodegaID int,
	Activo bit DEFAULT 1
	Primary Key(ID),
	Foreign Key (RolID) references Rol(RolID),
	Foreign Key (BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de RegistrarTecnicos*/
Create Table RegistrarTecnicos
(
	IDSolicitante int IDENTITY(1,1) not null,
	FechaRegistro DateTime,
	Nombres varchar(50),
	Apellidos varchar(50),
	DNI varchar(50),
	Direccion varchar(50),
	Num_Telefono varchar(50),
	Notas varchar(100),
	RequisaID int,
	Activo bit DEFAULT 1,
	Primary Key (IDSolicitante),
);

/*Creación de la tabla de RequisaSalida*/
Create Table RequisaSalida
(
	RequisaID int IDENTITY(1,1) not null,
	Solicitante varchar(50),
	Fecha DateTime,
	Descripcion varchar(50),
	Tecnico varchar(50),
	IDsolicitante int,
	Activo bit DEFAULT 1,
	Primary Key(RequisaID),
	Foreign Key (IDSolicitante) references RegistrarTecnicos(IDSolicitante)
);


/*Creación de la tabla de Proveedor*/
Create Table Proveedores
(
	IDProveedor int IDENTITY(1,1) NOT NULL,
	NombreProveedor varchar(50),
	RTN int,
	PersonaContacto varchar(50),
	Direccion varchar(50),
	Pais_Zona varchar(50),
    Tipo_Proveedor varchar(50),
	Num_Telefono varchar(50) UNIQUE,
	CorreoElectronico varchar(50),
	Notas varchar(150),
	Activo bit DEFAULT 1,
	Primary Key(IDProveedor)
);

/*Creación de la tabla de RequisaEntrada*/
Create Table RequisaEntrada
(
	RequisaID int IDENTITY(1,1) not null,
	Nombre varchar(50),
	NumOrden int,
	Descripcion varchar(50),
	Cantidad int,
	PrecioCompra Decimal,
	PrecioVenta Decimal,
	Subtotal Decimal,
	Activo bit DEFAULT 1,
	IDProveedor int,
	BodegaID int,
	Primary Key(RequisaID),
	Foreign Key (BodegaID) references Bodega(BodegaID),
	Foreign Key (IDProveedor) references Proveedores(IDProveedor)
);



/*Creación de la tabla de RegistrarBaseForanea*/
Create Table RegistrarBaseForanea
(
	IDSolicitante int IDENTITY(1,1) NOT NULL,
	FechaRegistro DateTime,
	Nombre varchar(50),
	Lugar_Zona varchar(50),
	Direccion varchar(50),
	Num_Telefono varchar(50),
    Notas varchar(50),
	Activo bit DEFAULT 1,
	Primary Key(IDSolicitante)
);


/*Creación de la tabla de RegistrarPuntodeVenta*/
Create Table RegistrarPuntodeVenta
(
	IDSolicitante int IDENTITY(1,1) NOT NULL,
	FechaRegistro DateTime,
	Nombre varchar(50),
	Lugar_Zona varchar(50),
	Dirección varchar(50),
	Num_Telefono varchar(50),
	Notas varchar(150),
	Activo bit DEFAULT 1,
	Primary Key(IDSolicitante)
);



/*Creación de la tabla de InventarioBodega1*/
Create Table InventarioBodega1
(
	IDInventarioBodega1 int IDENTITY(1,1) not null
    ,Fecha DateTime
    ,Codigo int
    ,Descripción varchar(150)
    ,Entrada int
    ,Salida int
    ,Existencia int
    ,Observacion varchar(150)
	,BodegaID int
	,Activo bit DEFAULT 1
	,Primary Key(IDInventarioBodega1)
	,Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de InventarioBodega2*/
Create Table InventarioBodega2
(
	IDInventarioBodega2 int IDENTITY(1,1) not null
    ,Fecha DateTime
    ,Codigo int
    ,Descripción varchar(150)
    ,Entrada int
    ,Salida int
    ,Existencia int
    ,Observacion varchar(150)
	,BodegaID int
	,Activo bit DEFAULT 1
	,Primary Key(IDInventarioBodega2)
	,Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de InventarioBodega3*/
Create Table InventarioBodega3
(
	IDInventarioBodega3 int IDENTITY(1,1) not null,
    Fecha DateTime,
    Codigo int,
    Descripción varchar(150),
    Entrada int,
    Salida int,
    Existencia int,
    Observacion varchar(150),
	BodegaID int,
	Activo bit DEFAULT 1,
	Primary Key(IDInventarioBodega3),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de InventarioBodega4*/
Create Table InventarioBodega4
(
	IDInventarioBodega4 int IDENTITY(1,1) not null,
    Fecha DateTime,
    Codigo int,
    Descripción varchar(150),
    Entrada int,
    Salida int,
    Existencia int,
    Observacion varchar(150),
	BodegaID int,
	Activo bit DEFAULT 1,
	Primary Key(IDInventarioBodega4),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);
--Drop Table Producto


/*Creación de la tabla de Producto*/
Create Table Producto
(
	IDProducto int IDENTITY(1,1) NOT NULL,
	FechaIngreso DateTime,
	CodigoProd varchar(50),
	CodigoGen varchar(50),
	Descripcion varchar(100),
	BodegaID int,
	NombreTipo varchar(50),
	Activo bit DEFAULT 1,
	Primary Key(IDProducto),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);

Create Table TipoMaterial
(
	IDTipo int IDENTITY(1,1) NOT NULL,
	NombreTipo varchar(50)
	PRIMARY KEY(IDTipo)
);




/*Creación de la tabla de BajosMinimos*/
Create Table BajosMinimos
(
	IDBajosMinimos int IDENTITY(1,1) NOT NULL,
	Fecha DateTime,
	Codigo int,
	Descripcion varchar(100),
	Medida varchar(50),
	Ideal int,
	Diferencia int,
	Activo bit DEFAULT 1,
	BodegaID int,
	Primary Key(IDBajosMinimos),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de AjusteInventario*/
Create Table AjusteInventario
(
	ID int IDENTITY(1,1) NOT NULL,
	BodegaID int,
	Codigo int,
	Descripcion varchar(100),
	Existencia int,
	Faltante_Sobrante decimal,
	TipodeAjuste varchar(50),
	Cantidad decimal,
	Cantidad_Ajustada decimal,
	Activo bit DEFAULT 1,
	Primary Key(ID),
	Foreign Key (BodegaID) references Bodega(BodegaID)
);


/*Creación de la tabla de Devoluciones*/
Create Table Devoluciones
(
	ID int IDENTITY(1,1) NOT NULL,
	Codigo int,
	Descripcion varchar(100),
	Medida int,
	Entregado int,
	Devuelto int,
	RequisaID int,
	Activo bit DEFAULT 1,
	Primary Key(ID),
	Foreign Key (RequisaID) references RequisaSalida(RequisaID)
);


/*Creación de la tabla de Compras*/
Create Table Compras
(
	IDCompra int IDENTITY(1,1) NOT NULL,
	Cantidad int,
	NumOrden int,
	Fecha DateTime,
	Codigo int,
	Producto varchar(100),
	PrecioUnitarioCompraDolares decimal,
	CostFOBDolares decimal,
	CostosDeTransporte decimal,
	CostoCIFDolares decimal,
	CostoCIFLempiras decimal,
	CostosDeImportacion decimal,
	CostoTotalCompraLempiras decimal,
	CostoTotalCompraDolares decimal,
	IDProveedor int,
	Activo bit DEFAULT 1,
	Primary Key(IDCompra),
	Foreign Key(IDProveedor) references Proveedores(IDProveedor)
);

/*Creación de la tabla de ComprobanteEntrega*/
Create Table ComprobanteEntrega
(
	ID int IDENTITY(1,1) NOT NULL,
	FechaEntrega DateTime,
	Cliente varchar(65),
	Direccion varchar(100),
	Descripcion varchar(150),
	unidades varchar(50),
	Metros decimal,
	Observacion varchar(150),
	IDProducto int,
	Activo bit DEFAULT 1,
	Primary Key(ID),
	Foreign Key (IDProducto) references Producto(IDProducto)
);

/*Creación de la tabla de PermisosAdministrador*/
Create Table PermisosAdministrador
(
	ID int IDENTITY(1,1) NOT NULL,
	NombrePermiso varchar(100),
	Concedido bit,
	UsuarioID int,
	Activo bit DEFAULT 1,
	RolID int,
	Primary Key(ID),
	Foreign Key (UsuarioID) references Usuario(ID),
	Foreign Key (RolID) references Rol(RolID)
);

/*Creación de la tabla de PermisosCompras*/
Create Table PermisosCompras
(
	ID int IDENTITY(1,1) NOT NULL,
	NombrePermiso varchar(100),
	Concedido bit,
	UsuarioID int,
	Activo bit DEFAULT 1,
	RolID int,
	Primary Key(ID),
	Foreign Key (UsuarioID) references Usuario(ID),
	Foreign Key (RolID) references Rol(RolID)
);

/*Creación de la tabla de PermisosEncargadoBodega*/
Create Table PermisosEncargadoBodega
(
	ID int IDENTITY(1,1) NOT NULL,
	NombrePermiso varchar(100),
	Concedido bit,
	UsuarioID int,
	Activo bit DEFAULT 1,
	RolID int,
	BodegaID int,
	Primary Key(ID),
	Foreign Key (UsuarioID) references Usuario(ID),
	Foreign Key (RolID) references Rol(RolID),
	Foreign Key (BodegaID) references Bodega(BodegaID)
);


exec VistaUsuario
Select * From Usuario
Select * From Rol
Select * From Bodega
Delete Usuario

CREATE PROCEDURE dbo.VistaUsuario 
AS BEGIN 
SELECT dbo.Usuario.ID, dbo.Usuario.Nombre, dbo.Usuario.NombreUsuario, dbo.Usuario.NumTelefono, 
dbo.Usuario.Contrasena, dbo.Usuario.ConfirmarContrasena, dbo.Bodega.Nombre AS Bodega_Asignada, 
dbo.Rol.RolName, dbo.Usuario.Activo 
FROM dbo.Bodega 
INNER JOIN dbo.Usuario ON dbo.Bodega.BodegaID = dbo.Usuario.BodegaID 
INNER JOIN dbo.Rol ON dbo.Usuario.RolID = dbo.Rol.RolID 
END


UPDATE USUARIO  
SET COLUM
select * from Productos