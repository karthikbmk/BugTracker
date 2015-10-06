USE [freshers]
GO

/****** Object:  Table [dbo].[userDetails]    Script Date: 09/09/2013 19:54:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[userDetails](
	[ID] [smallint] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[EmailID] [varchar](100) NOT NULL,
	[Role] [varchar](30) NOT NULL,
	[param1] [varchar](200) NULL,
	[param2] [varchar](200) NULL,
	[param3] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


