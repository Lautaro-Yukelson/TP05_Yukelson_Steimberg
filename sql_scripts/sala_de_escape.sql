USE [sala_de_escape]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 27/6/2023 22:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[idJugador] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[errores] [int] NOT NULL,
	[tiempo] [time](0) NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[idJugador] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/6/2023 22:33:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[admin] [bit] NOT NULL,
	[usuario] [varchar](255) NOT NULL,
	[contrasena] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([idJugador], [nombre], [errores], [tiempo]) VALUES (1, N'Superman', 1, CAST(N'00:01:30' AS Time))
INSERT [dbo].[Jugadores] ([idJugador], [nombre], [errores], [tiempo]) VALUES (2, N'Messi', 0, CAST(N'00:00:45' AS Time))
INSERT [dbo].[Jugadores] ([idJugador], [nombre], [errores], [tiempo]) VALUES (4, N'Yuke', 0, CAST(N'00:00:25' AS Time))
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([idUsuario], [admin], [usuario], [contrasena]) VALUES (1, 1, N'adm', N'adm')
INSERT [dbo].[Usuarios] ([idUsuario], [admin], [usuario], [contrasena]) VALUES (2, 0, N'normal', N'normal')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
