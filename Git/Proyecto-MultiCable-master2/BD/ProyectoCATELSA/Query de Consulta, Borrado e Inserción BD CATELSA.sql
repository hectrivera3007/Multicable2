SELECT * FROM Rol
SELECT * FROM Usuario
Exec VistaUsuario
Select * FROM Bodega
Select * FROM Productos
Select * FROM TipoMaterial

DBCC CHECKIDENT ('Rol', RESEED, 0);
DBCC CHECKIDENT ('Usuario', RESEED, 0);
DBCC CHECKIDENT ('Bodega', RESEED, 0);
DBCC CHECKIDENT ('Productos', RESEED, 0);
DBCC CHECKIDENT ('TipoMaterial', RESEED, 0);

DROP DATABASE "CATELSA-MULTICABLE"
DELETE from Usuario WHERE Activo=NULL
DELETE from Rol WHERE Activo=1
DELETE from Bodega WHERE BodegaID=7
DELETE from Producto WHERE Activo=1
DELETE from Productos WHERE IDProducto=1
DELETE FROM TipoMaterial WHERE IDTipo=NULL

INSERT INTO Rol VALUES('Administración',1)
INSERT INTO Rol VALUES('Encargado de Bodega',1)
INSERT INTO Rol VALUES('Compras',1)
SELECT * FROM Rol

--INSERT INTO Usuario(Nombre, NombreUsuario, NumTelefono, Contrasena, ConfirmarContrasena, RolID, BodegaID, Activo)
--VALUES(@Nombre, @NombreUsuario, @NumTelefono, @Contrasena, @ConfirmarContrasena,@RolID, @BodegaID, @Activo)

--INSERT INTO [dbo].[Usuario] ([Nombre], [NombreUsuario], [NumTelefono], [Contrasena], [ConfirmarContrasena], [RolID], [BodegaID], [Activo])
--VALUES (@Nombre, @NombreUsuario, @NumTelefono, @Contrasena, @ConfirmarContrasena, @RolID, @BodegaID, @Activo);

--SELECT ID, Nombre, NombreUsuario, NumTelefono, Contrasena, ConfirmarContrasena, RolID, BodegaID, Activo FROM Usuario WHERE (ID = SCOPE_IDENTITY())

INSERT INTO Usuario VALUES('Hector Iván Rivera Cabrera', 'hector.rivera', '9647-2222', 'Progreso1029', 'Progreso1029', 1, 1, 1)
INSERT INTO Usuario VALUES('Rosa Saraí Sarmiento Bautista', 'sarai.sarmiento', '9728-5971', 'ccshh2023', 'ccshh2023', 2, 1, 1)
INSERT INTO Usuario VALUES('Hector Santiago Rivera Sarmiento', 'santiago.rivera', '9647-2222', 'Santibebe', 'Santibebe', 1, 2, 1)
INSERT INTO Usuario VALUES('Camila del Carmen Cabrera', 'camila.cabrera', '8794-0498', 'Cabrera_2023', 'Cabrera_2023', 3, 1, 1)
INSERT INTO Usuario VALUES('Juanitta Dinora Ferrera Tobar', 'j.ferrerat', '9435-2034', 'ferrerat2023', 'ferrerat2023', 2, 1, 1)
INSERT INTO Usuario VALUES('Kevin Antonio Rivera Cabrera', 'k.rivera01', '9959-2089', 'Sathsa2023', 'Sathsa2023', 3, 1, 1)

exec VistaUsuario

SELECT * FROM Usuario

INSERT INTO Bodega VALUES('Bodega Cama Nacional',1)
INSERT INTO Bodega VALUES('Bodega Catelsa Abajo',1)
INSERT INTO Bodega VALUES('Bodega 27 Calle',1)
INSERT INTO Bodega VALUES('Bodega Oficina',1)
Select * From Bodega

Select * FROM TipoMaterial
INSERT INTO TipoMaterial(TipoMaterial, Numeracion) VALUES('MPI','00001')
INSERT INTO TipoMaterial(TipoMaterial, Numeracion) VALUES('MPF','00002')
INSERT INTO TipoMaterial(TipoMaterial, Numeracion) VALUES('MPC','00003')
INSERT INTO TipoMaterial(TipoMaterial, Numeracion) VALUES('MPN','00004')

SELECT * FROM Producto
INSERT INTO Producto(FechaIngreso,[Tipo Material],Codigo,Descripcion,BodegaID,Activo) VALUES('2021-08-31 14:30:00', 1, 00001, 'ONU HUAWEI CAT TV/INTERNET', 1, 1)


INSERT INTO Productos (FechaIngreso, TipoMaterial, Codigo, Descripcion, BodegaID, IDTipo, Activo)
VALUES
('2021-06-15', 'MPI', 'MPI - 001', 'ONU HUAWEI DUAL BAND', 1, 1, 1),
('2021-06-15', 'MPI', 'MPI - 00002', 'ONU HUAWEI CAT TV/INTERNET', 1, 1, 1),
('2021-06-15', 'MPI', 'MPI - 00003', 'ONU STAR PONI CAT TV/INTERNET ', 1, 1, 1),
('2021-06-15', 'MPN', 'MPN - 00001', 'ROUTER MIKROTIK 951 C/W', 2, 2, 1),
('2021-06-15', 'MPN', 'MPN - 00002', 'EQUIPO OLT HUAWEI GRANDE', 2, 2, 1),
('2021-06-15', 'MPN', 'MPN - 00003', 'EQUIPO IP TO ANALAGO DE 64 CANALES ', 2, 2, 1),
('2021-06-15', 'MPC', 'MPC - 00001', 'CIERRE OPTICO GPON C/CASEP TELEDATA (DISTRIBUCIÓN)', 3, 3, 1),
('2021-06-15', 'MPC', 'MPC - 00002', 'CIERRES ÓPTICOS FOSC 400 TELEDATA (TRONCAL)', 3, 3, 1),
('2021-06-15', 'MPC', 'MPC - 00003', 'PIGTAIL DE COLOR 1.5MTS SC-VERDE 1X8 ', 3, 3, 1),
('2021-06-15', 'MPF', 'MPF - 00001', 'FIBRA ÓPTICA 48H ARMADA (TRONCAL)', 4, 4, 1),
('2021-06-15', 'MPF', 'MPF - 00002', 'FIBRA OPTICA 12H ADSS (TRONCAL/DISTRIBUCIÓN)', 4, 4, 1),
('2021-06-15', 'MPF', 'MPF - 00003', 'HERRAJES TIPO D', 4, 4, 1);

UPDATE Productos SET Codigo = CONCAT(TipoMaterial, '-', REPLICATE('0', 4 - LEN(IDProducto)), IDProducto);

--REESTRUCTURAR LA TABLA PRODUCTO, CONSIDERAR QUE CON LA CREACIÓN DE CODIGOS CREADOS POR TIPO DE MATERIAL
--SE NECESITAN DIFERENTES ID PARA QUE VAYAN INCREMENTANDO SEGUN EL CODIGO


CREATE TABLE Productos (
  IDProducto INT IDENTITY(1,1),
  FechaIngreso DATE,
  TipoMaterial VARCHAR(50),
  Codigo VARCHAR(10),
  Descripcion VARCHAR(100),
  BodegaID INT,
  IDTipo INT,
  Activo BIT Default 1,
  FOREIGN KEY (IDTipo) REFERENCES TipoMaterial(IDTipo),
  FOREIGN KEY (BodegaID) REFERENCES Bodega(BodegaID)
);


CREATE TABLE TipoMaterial (
  IDTipo INT NOT NULL IDENTITY(1,1),
  TipoMaterial VARCHAR(50),
  Numeracion VARCHAR(50), 
  PRIMARY KEY (IDTipo)
);



SELECT * FROM Productos



SELECT Usuario.Nombre, Rol.RolName
FROM Usuario
INNER JOIN Rol ON Usuario.RolID = Rol.RolID
