USE [sala_de_escape]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 24/6/2023 19:15:38 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([idJugador], [nombre], [errores], [tiempo]) VALUES (1, N'Superman', 1, CAST(N'00:01:30' AS Time))
INSERT [dbo].[Jugadores] ([idJugador], [nombre], [errores], [tiempo]) VALUES (2, N'Messi', 0, CAST(N'00:00:45' AS Time))
INSERT [dbo].[Jugadores] ([idJugador], [nombre], [errores], [tiempo]) VALUES (3, N'Juan', 0, CAST(N'01:20:10' AS Time))
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
