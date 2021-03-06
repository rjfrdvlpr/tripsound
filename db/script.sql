/****** Object:  Table [dbo].[TRIPSOUND.EQUIPOS]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.EQUIPOS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Marca] [nvarchar](50) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_TRIPSOUND.EQUIPOS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.EVENTO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.EVENTO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[FechaInicio] [date] NULL,
	[HoraInicio] [time](7) NULL,
	[HoraFinal] [time](7) NULL,
	[Direccion] [nvarchar](150) NULL,
	[Referencia] [nvarchar](150) NULL,
	[idusuario] [int] NOT NULL,
 CONSTRAINT [PK_TRIPSOUND.EVENTO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.EVENTO_DETALLE_EQUIPO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.EVENTO_DETALLE_EQUIPO](
	[ID] [int] NOT NULL,
	[Fechasalida] [datetime] NULL,
	[Fechaentrada] [datetime] NULL,
	[Notas] [nvarchar](100) NULL,
	[idevento] [int] NULL,
	[idequipo] [int] NULL,
 CONSTRAINT [PK_TRIPSOUND.EVENTO_DETALLE_EQUIPO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.EVENTO_DJS]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.EVENTO_DJS](
	[ID] [int] NOT NULL,
	[id_dj] [int] NULL,
	[id_evento] [int] NULL,
 CONSTRAINT [PK_TRIPSOUND.EVENTO_DJS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.PERSONAL]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.PERSONAL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[fecha_nacimiento] [date] NULL,
	[dni] [nvarchar](50) NULL,
	[celular] [int] NULL,
	[correo] [nvarchar](50) NULL,
	[tipo] [int] NULL,
	[foto] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRIPSOUND.PERSONAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.TIPO_PERSONAL]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.TIPO_PERSONAL](
	[ID] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRIPSOUND.TIPO_PERSONAL] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.TIPODEPAGO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.TIPODEPAGO](
	[ID] [int] NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRIPSOUND.TIPODEPAGO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.TIPOUSUARIO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.TIPOUSUARIO](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRIPSOUND.TIPOUSUARIO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.USUARIO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.USUARIO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [nvarchar](50) NULL,
	[apellidos] [nvarchar](50) NULL,
	[cel] [int] NULL,
	[correo] [nvarchar](50) NULL,
	[contra] [nvarchar](20) NULL,
	[idtipousu] [int] NULL,
	[DNI] [int] NULL,
 CONSTRAINT [PK_TRIPSOUND.USUARIO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRIPSOUND.VENTAS]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRIPSOUND.VENTAS](
	[ID] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[total] [decimal](18, 2) NULL,
	[idtipopago] [int] NULL,
	[idtipoevento] [int] NULL,
 CONSTRAINT [PK_TRIPSOUND.VENTAS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.EVENTO_TRIPSOUND.USUARIO] FOREIGN KEY([idusuario])
REFERENCES [dbo].[TRIPSOUND.USUARIO] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO] CHECK CONSTRAINT [FK_TRIPSOUND.EVENTO_TRIPSOUND.USUARIO]
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DETALLE_EQUIPO]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.EVENTO_DETALLE_EQUIPO_TRIPSOUND.EQUIPOS] FOREIGN KEY([idequipo])
REFERENCES [dbo].[TRIPSOUND.EQUIPOS] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DETALLE_EQUIPO] CHECK CONSTRAINT [FK_TRIPSOUND.EVENTO_DETALLE_EQUIPO_TRIPSOUND.EQUIPOS]
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DETALLE_EQUIPO]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.EVENTO_DETALLE_EQUIPO_TRIPSOUND.EVENTO] FOREIGN KEY([idevento])
REFERENCES [dbo].[TRIPSOUND.EVENTO] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DETALLE_EQUIPO] CHECK CONSTRAINT [FK_TRIPSOUND.EVENTO_DETALLE_EQUIPO_TRIPSOUND.EVENTO]
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DJS]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.EVENTO_DJS_TRIPSOUND.EVENTO] FOREIGN KEY([id_evento])
REFERENCES [dbo].[TRIPSOUND.EVENTO] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DJS] CHECK CONSTRAINT [FK_TRIPSOUND.EVENTO_DJS_TRIPSOUND.EVENTO]
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DJS]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.EVENTO_DJS_TRIPSOUND.PERSONAL] FOREIGN KEY([id_dj])
REFERENCES [dbo].[TRIPSOUND.PERSONAL] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.EVENTO_DJS] CHECK CONSTRAINT [FK_TRIPSOUND.EVENTO_DJS_TRIPSOUND.PERSONAL]
GO
ALTER TABLE [dbo].[TRIPSOUND.PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.PERSONAL_TRIPSOUND.TIPO_PERSONAL] FOREIGN KEY([tipo])
REFERENCES [dbo].[TRIPSOUND.TIPO_PERSONAL] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.PERSONAL] CHECK CONSTRAINT [FK_TRIPSOUND.PERSONAL_TRIPSOUND.TIPO_PERSONAL]
GO
ALTER TABLE [dbo].[TRIPSOUND.USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.USUARIO_TRIPSOUND.TIPOUSUARIO] FOREIGN KEY([idtipousu])
REFERENCES [dbo].[TRIPSOUND.TIPOUSUARIO] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.USUARIO] CHECK CONSTRAINT [FK_TRIPSOUND.USUARIO_TRIPSOUND.TIPOUSUARIO]
GO
ALTER TABLE [dbo].[TRIPSOUND.VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.VENTAS_TRIPSOUND.EVENTO] FOREIGN KEY([idtipoevento])
REFERENCES [dbo].[TRIPSOUND.EVENTO] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.VENTAS] CHECK CONSTRAINT [FK_TRIPSOUND.VENTAS_TRIPSOUND.EVENTO]
GO
ALTER TABLE [dbo].[TRIPSOUND.VENTAS]  WITH CHECK ADD  CONSTRAINT [FK_TRIPSOUND.VENTAS_TRIPSOUND.TIPODEPAGO] FOREIGN KEY([idtipopago])
REFERENCES [dbo].[TRIPSOUND.TIPODEPAGO] ([ID])
GO
ALTER TABLE [dbo].[TRIPSOUND.VENTAS] CHECK CONSTRAINT [FK_TRIPSOUND.VENTAS_TRIPSOUND.TIPODEPAGO]
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_BUSCARCLIENTE]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TRIPSOUND_BUSCARCLIENTE]
@id int
as begin
SELECT        ID, nombres, apellidos, cel, correo, contra, DNI
FROM            dbo.[TRIPSOUND.USUARIO]
WHERE        (ID = @id)
end
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_LISTARCLIENTES]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TRIPSOUND_LISTARCLIENTES]
AS BEGIN
SELECT      id,  DNI, nombres AS NOMBRES, apellidos AS APELLIDOS, cel AS CELULAR, correo AS CORREO
FROM            dbo.[TRIPSOUND.USUARIO]
END
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_LISTARINVENTARIO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TRIPSOUND_LISTARINVENTARIO]
AS BEGIN
SELECT        ID, Nombre, Marca, cantidad
FROM            dbo.[TRIPSOUND.EQUIPOS]
END
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_LISTARPERSONAL]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TRIPSOUND_LISTARPERSONAL]
AS BEGIN
SELECT        dbo.[TRIPSOUND.PERSONAL].*
FROM            dbo.[TRIPSOUND.PERSONAL]
END
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_REGISTRARCLIENTES]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TRIPSOUND_REGISTRARCLIENTES]
@nom nvarchar(50),
@apellidos nvarchar(50),
@cel int,
@correo nvarchar(50),
@contraseña nvarchar(20),
@tipo int,
@dni int

as begin
insert into [TRIPSOUND.USUARIO] values (@nom,
@apellidos,@cel,@correo,@contraseña,1,@dni)
end
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_REGISTRAREQUIPOS]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TRIPSOUND_REGISTRAREQUIPOS]
@nom nvarchar(50),
@marca nvarchar(50),

@cantidad int

as begin
insert into [TRIPSOUND.EQUIPOS] values (@nom,
@marca, @cantidad)
end
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_REGISTRAREVENTO]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TRIPSOUND_REGISTRAREVENTO]
@nombre nvarchar(50),
@fechainicio date,
@horainicio time,
@horafinal time,
@direccion nvarchar(100),
@referencia nvarchar(150),
@idusuario int
as begin
insert into [TRIPSOUND.EVENTO] values(
@nombre,@fechainicio,@horainicio,@horafinal,@direccion,
@referencia,@idusuario)
end
GO
/****** Object:  StoredProcedure [dbo].[TRIPSOUND_REGISTRARPERSONAL]    Script Date: 18/10/2021 21:49:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TRIPSOUND_REGISTRARPERSONAL]
@nom nvarchar(50),
@ape nvarchar(50),
@nacimie date,
@dni int,
@cel int,
@correo nvarchar(50),
@foto nvarchar(50)
as begin
insert into [TRIPSOUND.PERSONAL] values (@nom,
@ape, @nacimie,@dni,@cel,@correo,1,@foto)
end
GO
