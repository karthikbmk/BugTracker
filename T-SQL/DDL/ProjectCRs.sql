USE [freshers]
GO

/****** Object:  Table [dbo].[ProjectCRs]    Script Date: 09/09/2013 19:55:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProjectCRs](
	[PrjName] [varchar](100) NULL,
	[CRName] [varchar](100) NULL,
	[CRDescription] [varchar](200) NULL,
	[param1] [varchar](200) NULL,
	[param2] [varchar](200) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


