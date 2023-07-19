CREATE PROCEDURE InsertarProducto
    @FechaIngreso DATE,
    @TipoMaterial VARCHAR(50),
    @Codigo VARCHAR(50),
    @Descripcion VARCHAR(100),
    @BodegaID INT,
    @Activo BIT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Productos (FechaIngreso, TipoMaterial, Codigo, Descripcion, BodegaID, IDTipo, Activo)
    SELECT @FechaIngreso, CONCAT(TM.TipoMaterial, '-', @Codigo), @Codigo, @Descripcion, B.BodegaID, TM.TipoMaterial, @Activo
    FROM Bodega AS B
    INNER JOIN TipoMaterial AS TM ON B.BodegaID = TM.IDTipo
    WHERE B.BodegaID = @BodegaID AND TM.TipoMaterial = @TipoMaterial
      AND NOT EXISTS (
        SELECT 1
        FROM Productos
        WHERE Codigo = @Codigo
    );
END;
