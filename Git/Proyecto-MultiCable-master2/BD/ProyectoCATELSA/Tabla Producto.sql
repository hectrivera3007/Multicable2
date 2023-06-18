SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IDProducto] [int] IDENTITY(1,1) NOT NULL,
	[FechaIngreso] [datetime] NULL,
	[Tipo Material] [varchar](50) NULL,
	[Codigo] [varchar](50) NULL,
	[Descripcion] [varchar](100) NULL,
	[BodegaID] [int] NULL,
	[Activo] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([BodegaID])
REFERENCES [dbo].[Bodega] ([BodegaID])
GO
