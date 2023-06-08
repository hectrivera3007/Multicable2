/*Creación de la Base de Datos*/
--Create DATABASE "CATELSA-MULTICABLE"
--USE [CATELSA-MULTICABLE]

--ALTER TABLE Usuario WITH NOCHECK CHECK CONSTRAINT FK;
DBCC CHECKIDENT ('Usuario', RESEED, 0);

--Creación de la tabla Roles
Create Table Rol
(
	RolID int IDENTITY(1,1) not null,
	RolName varchar(50) UNIQUE,
	Activo bit not null DEFAULT 1
	Primary Key (RolID),
);


ALTER TABLE Rol ADD CONSTRAINT UQ_Rol_RolName UNIQUE(RolName);



/*Creación de la tabla de Bodega*/
Create Table Bodega
(
	BodegaID int IDENTITY(1,1) not null,
	Nombre varchar(50),
	Activo bit not null DEFAULT 1,
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
	RolID int not null,
	BodegaID int not null,
	Activo bit not null DEFAULT 1
	Primary Key(ID),
	Foreign Key (RolID) references Rol(RolID),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de RegistrarTecnicos*/
Create Table RegistrarTecnicos
(
	IDSolicitante int IDENTITY(1,1) not null,
	FechaRegistro DateTime,
	Nombres varchar(50),
	Apellidos varchar(50),
	DNI varchar(50) UNIQUE,
	Direccion varchar(50),
	Num_Telefono varchar(50) UNIQUE,
	Notas varchar(100),
	RequisaID integer not null,
	Activo bit not null DEFAULT 1,
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
	Activo bit not null DEFAULT 1,
	Primary Key(RequisaID),
	Foreign Key (IDSolicitante) references RegistrarTecnicos(IDSolicitante)
);


/*Creación de la tabla de Proveedor*/
Create Table Proveedores
(
	IDProveedor int IDENTITY(1,1) NOT NULL,
	NombreProveedor varchar(50),
	RTN int UNIQUE,
	PersonaContacto varchar(50),
	Direccion varchar(50),
	Pais_Zona varchar(50),
    Tipo_Proveedor varchar(50),
	Num_Telefono varchar(50) UNIQUE,
	CorreoElectronico varchar(50) UNIQUE,
	Notas varchar(150),
	Activo bit not null DEFAULT 1,
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
	Activo bit not null DEFAULT 1,
	IDProveedor int not null,
	BodegaID int not null,
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
	Num_Telefono varchar(50) UNIQUE,
    Notas varchar(50),
	Activo bit not null DEFAULT 1,
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
	Num_Telefono varchar(50) UNIQUE,
	Notas varchar(150),
	Activo bit not null DEFAULT 1,
	Primary Key(IDSolicitante)
);



/*Creación de la tabla de InventarioBodega1*/
Create Table InventarioBodega1
(
	IDInventarioBodega1 int IDENTITY(1,1) not null,
    Fecha DateTime,
    Codigo int,
    Descripción varchar(150),
    Entrada int,
    Salida int,
    Existencia int,
    Observacion varchar(150),
	BodegaID int,
	Activo bit not null DEFAULT 1,
	Primary Key(IDInventarioBodega1),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de InventarioBodega2*/
Create Table InventarioBodega2
(
	IDInventarioBodega2 int IDENTITY(1,1) not null,
    Fecha DateTime,
    Codigo int,
    Descripción varchar(150),
    Entrada int,
    Salida int,
    Existencia int,
    Observacion varchar(150),
	BodegaID int,
	Activo bit not null DEFAULT 1,
	Primary Key(IDInventarioBodega2),
	Foreign Key(BodegaID) references Bodega(BodegaID)
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
	Activo bit not null DEFAULT 1,
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
	Activo bit not null DEFAULT 1,
	Primary Key(IDInventarioBodega4),
	Foreign Key(BodegaID) references Bodega(BodegaID)
);

/*Creación de la tabla de Producto*/
Create Table Producto
(
	IDProducto int IDENTITY(1,1) NOT NULL,
	FechaIngreso DateTime,
	CodigoProd int,
	Descripcion varchar(100),
	Numero_Documento varchar(50),
	BodegaID int,
	Activo bit not null DEFAULT 1,
	Primary Key(IDProducto),
	Foreign Key(BodegaID) references Bodega(BodegaID)
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
	Activo bit not null DEFAULT 1,
	BodegaID int not null,
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
	Activo bit not null DEFAULT 1,
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
	Primary Key(ID),
	Activo bit not null DEFAULT 1,
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
	Activo bit not null DEFAULT 1,
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
	Activo bit not null DEFAULT 1,
	Primary Key(ID),
	Foreign Key (IDProducto) references Producto(IDProducto)
);


ALTER TABLE Usuario ADD FOREIGN KEY (RolID) REFERENCES Rol (RolID); 

--MIRE AMIX, ASÍ ES MI IDEA DE HACERLO
/*Creación de la tabla de PermisosAdministrador*/
Create Table PermisosAdministrador
(
	ID int IDENTITY(1,1) NOT NULL,
	NombrePermiso varchar(100),
	Concedido bit,
	UsuarioID int not null,
	Activo bit not null DEFAULT 1,
	RolID int not null,
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
	UsuarioID int not null,
	Activo bit not null DEFAULT 1,
	RolID int not null,
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
	UsuarioID int not null,
	Activo bit not null DEFAULT 1,
	RolID int not null,
	BodegaID int not null,
	Primary Key(ID),
	Foreign Key (UsuarioID) references Usuario(ID),
	Foreign Key (RolID) references Rol(RolID),
	Foreign Key (BodegaID) references Bodega(BodegaID)
);

--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Ingresar Producto', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Agregar Producto Existente', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Devoluciones', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Inventario General', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Ajuste de Inventario', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Requisa de Entrada', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Requisa de Salida', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Buscar Entrada', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Buscar Salida', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Comprobante de Entrega', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Bodega 1', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Bodega 2', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Bodega 3', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Bodega 4', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Compras', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Costos de Importacion', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Calcular Precio de Venta', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Registrar Base Foranea', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Registrar Punto de Venta', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Registrar Proveedor', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Registrar Tecnico', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Listar Proveedor', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Listar Punto de Venta', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Listar Tecnico', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Listar Base Foranea', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte Bodega 1', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte Bodega 2', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte Bodega 3', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte Bodega 4', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte de Bajos Minimos', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte Detallado de Entradas', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Reporte Detallado de Salidas', 1, 1)
--insert into Permisos (NombrePermiso, Concedido, UsuarioID) values ('Crear Nuevo Usuario', 1, 1)


--Update Permisos 
--set Concedido = 0

Delete From Bodega Where RolID=4

SELECT * FROM Bodega;

UPDATE Rol
SET  Activo=0
WHERE Activo=1

/*Creación de la tabla de Usuario_Permisos
Create Table Usuario_Permisos
(
	Usuario_PermisosID int IDENTITY(1,1) NOT NULL,
	NombrePermiso varchar(100),
	Valor bit,
	ID int
	Primary Key(Usuario_PermisosID),
	Foreign Key(ID) references Usuario(ID)
);

/*Creación de la tabla de Permisos*/
Create Table Rol_Permisos
(
	IdRol int IDENTITY(1,1) NOT NULL,
	Permiso varchar(100),
	Valor bit,
	Usuario_PermisosID int not null,
	RolID int
	Primary Key(IdRol),
	Foreign Key (Usuario_PermisosID) references Usuario_Permisos(Usuario_PermisosID),
	Foreign Key(RolID) references Rol(RolID)
);*/


UPDATE Rol
SET
RolName=RolName, Activo=1
WHERE
RolID=RolID;
Select * From Rol;