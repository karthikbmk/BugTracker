USE [freshers]
GO

/****** Object:  Table [dbo].[ftiProjects]    Script Date: 09/09/2013 19:55:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ftiProjects](
	[PrjID] [int] NOT NULL,
	[PrjName] [varchar](100) NULL,
	[PrjDescription] [varchar](500) NULL,
	[param1] [varchar](100) NULL,
	[param2] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[PrjID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


