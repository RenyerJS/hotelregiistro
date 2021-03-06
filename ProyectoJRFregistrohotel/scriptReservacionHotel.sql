USE [ReservacionHotel]
GO
/****** Object:  StoredProcedure [dbo].[nuevaHabitacion]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevaHabitacion] 
	-- Add the parameters for the stored procedure here
	@b INT,	@IdHabitacion int, @Precio int,@Codigo int, @Tipo char(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @b=1
		INSERT INTO Habitaciones VALUES(@IdHabitacion,@precio,@Tipo);

		if @b=2
		 select * from Habitaciones
	if @b=3
	      update Habitaciones set Precio=@precio, Tipo=@Tipo
		  where IdHabitacion=@IdHabitacion

	if @b=4
	     delete from Habitaciones where IdHabitacion=IdHabitacion

    if @b=5
	    select * from Habitaciones
		where IdHabitacion=IdHabitacion

	if @b=6
	    select*from Habitaciones
		where Precio like '%' + Precio+ '%' or Tipo like '%'+Tipo+'%'

END

GO
/****** Object:  StoredProcedure [dbo].[nuevaReservacion]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevaReservacion]
	-- Add the parameters for the stored procedure here
	@b INT,	@id int, @Fecha char(15),@Tiempo char(19), @NumeroCliente int,@Numero int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @b=1
		INSERT INTO Reservaciones VALUES(@Fecha,@Tiempo,@NumeroCliente,@Numero);

		if @b=2
		 select * from Reservaciones
	if @b=3
	      update Reservaciones set Fecha=@Fecha,Tiempo=@Tiempo
		  where id=id 


	if @b=4
	     delete from Reservaciones where id=id

    if @b=5
	    select * from Reservaciones
		where id=id

	--if @b=6
	  --select*from Reservaciones
	  --where Fecha like '%' +Fecha+ '%' or Tiempo like '%'+Tiempo+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[nuevoCliente]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[nuevoCliente]
	@b INT,	@NumeroCliente INT,@Cedula char(20), @Nombres char(30),@Apellidos varchar(30), @Direccion char(50), @Telefono CHAR(15), @tipocliente varchar (30)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @b=1
		INSERT INTO Clientes VALUES(@Cedula, @Nombres,@Apellidos, @Direccion, @Telefono, @tipocliente);

		if @b=2
		 select * from Clientes
	if @b=3
	      update Clientes set Cedula=@Cedula, Nombres=@Nombres,Apellidos=@Apellidos,Direccion=@Direccion,Telefono=@Telefono, tipocliente=@tipocliente
		  where NumeroCliente=@NumeroCliente

	if @b=4
	     delete from Clientes where NumeroCliente=NumeroCliente

    if @b=5
	    select * from Clientes
		where NumeroCliente=NumeroCliente

	if @b=6
	    select*from Clientes
		where Nombres like '%' + Nombres+ '%' or Direccion like '%'+Direccion+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[nuevoHotel]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[nuevoHotel]
	-- Add the parameters for the stored procedure here
	@b INT,	@Codigo int,  @Nombre char(20), @Direccion varchar(100),@Categoria char(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if @b=1
		INSERT INTO Hoteles VALUES(@Nombre,@Direccion,@Categoria); 

		if @b=2
		 select * from Hoteles
	if @b=3
	      update Hoteles set Nombre=@Nombre,Direccion=@Direccion,Categoria=@Categoria
		  where Codigo=Codigo


	if @b=4
	     delete from Hoteles where Codigo=Codigo

    if @b=5
	    select * from Hoteles
		where Codigo=Codigo

	if @b=6
	    select*from Hoteles
		where Nombre like '%' +Nombre+ '%' or Categoria like '%'+Categoria+'%'

END

GO
/****** Object:  StoredProcedure [dbo].[respaldoBD_ReservacionHotel]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[respaldoBD_ReservacionHotel] 

AS
BEGIN
	
	SET NOCOUNT ON;


	BACKUP DATABASE [ReservacionHotel]
	TO DISK = N'F:\Backup\rReservacionHotel.back'
	WITH CHECKSUM;
END

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[NumeroCliente] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [char](20) NOT NULL,
	[Nombres] [char](30) NOT NULL,
	[Apellidos] [varchar](30) NOT NULL,
	[Direccion] [char](50) NULL,
	[Telefono] [char](15) NULL,
	[TipoCliente] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Habitaciones]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Habitaciones](
	[IdHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[Precio] [int] NOT NULL,
	[Codigo] [int] NULL,
	[Tipo] [char](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hoteles]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hoteles](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [char](20) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Categoria] [char](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reservaciones]    Script Date: 28/11/2018 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reservaciones](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [time](7) NOT NULL,
	[Tiempo] [char](15) NOT NULL,
	[NumeroCliente] [int] NULL,
	[Numero] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (1, N'127080294000D       ', N'Francisco Javier              ', N'Carrasco Aviles', N'Santo Domingo                                     ', N'57651109       ', N'Particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (2, N'1270802940000D      ', N'Francisco Javier              ', N'Carrasco Aviles', N'Santo Domingo                                     ', N'57651109       ', N'Particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (3, N'1270804940000M      ', N'Guillermo Jose                ', N'Carrasco', N'Santo Domigo                                      ', N'89410424       ', N'Agencia')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (4, N'127-060280-0000M    ', N'Noel Javier                   ', N'Carrasco Aviles', N'Santo Domingo                                     ', N'89410424       ', N'Particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (6, N'1270802940000D      ', N'Francisco Javier              ', N'Carrasco Aviles', N'Santo Domingo                                     ', N'57651109       ', N'Particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (7, N'127080294000D       ', N'Francisco Antonio             ', N'Carrasco Aviles', N'Santo Domingo                                     ', N'57651109       ', N'Particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (8, N'127080294000D       ', N'Francisco Antonio             ', N'Carrasco Aviles', N'Santo Domingo                                     ', N'57651109       ', N'Particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (9, N'1461786870000D      ', N'belkis                        ', N'jaime', N'santo domingo                                     ', N'67813698765    ', N'particular')
INSERT [dbo].[Clientes] ([NumeroCliente], [Cedula], [Nombres], [Apellidos], [Direccion], [Telefono], [TipoCliente]) VALUES (10, N'643|6548328000t     ', N'FFQFR                         ', N'GRGQE', N'RTRERT                                            ', N'6577787        ', N'AGENCIA')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Hoteles] ON 

INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (1, N'Reyni Pan           ', N'Santo Domingo', N'Tes Estrellas  ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (2, N'San Juan            ', N'Santo Domingo', N'Cuatro estrella')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (3, N'Sn Jose             ', N'Santo Domingo', N'Tres Estrella  ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (4, N'San Jose            ', N'Santo Domingo', N'Tres Estrellas ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (5, N'el patio            ', N'santo domingo', N'dos estrellas  ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (6, N'sepa                ', N'la esquina', N'malo           ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (7, N'cajinaso            ', N'el puente', N'bueno          ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (8, N'Paraiso             ', N'Cruz azul dos al norte', N'Una estrella   ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (9, N'UnoMas              ', N'via vieja tres norte', N'bueno          ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (10, N'jhg                 ', N'ghyyyhh', N'hhhhhh         ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (11, N'San Juan            ', N'Juigalpa', N'Tres Estrella  ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (12, N'San juan            ', N'El ayote', N'cinco estrella ')
INSERT [dbo].[Hoteles] ([Codigo], [Nombre], [Direccion], [Categoria]) VALUES (13, N'La posada           ', N'Juigalpa', N'tres estrella  ')
SET IDENTITY_INSERT [dbo].[Hoteles] OFF
ALTER TABLE [dbo].[Habitaciones]  WITH CHECK ADD FOREIGN KEY([Codigo])
REFERENCES [dbo].[Hoteles] ([Codigo])
GO
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD FOREIGN KEY([NumeroCliente])
REFERENCES [dbo].[Clientes] ([NumeroCliente])
GO
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD FOREIGN KEY([Numero])
REFERENCES [dbo].[Habitaciones] ([IdHabitacion])
GO
