CREATE PROCEDURE NumerodeOrden
AS
BEGIN
    DECLARE @NumOrden INT
    SELECT @NumOrden = COALESCE(MAX(NumOrden), 0) + 1 FROM Compras
    INSERT INTO Compras (NumOrden, Fecha) VALUES (@NumOrden, GETDATE())
    SELECT @NumOrden AS Numero_Orden_Generado
END