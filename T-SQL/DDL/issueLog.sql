USE [freshers]
GO

/****** Object:  Table [dbo].[issueLog]    Script Date: 09/09/2013 19:56:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[issueLog](
	[IssueID] [int] IDENTITY(1,1) NOT NULL,
	[PrjName] [varchar](100) NULL,
	[CRName] [varchar](100) NULL,
	[IssueDesc] [varchar](500) NULL,
	[Severity] [varchar](20) NULL,
	[Status] [varchar](20) NULL,
	[Developer] [varchar](50) NULL,
	[Tester] [varchar](50) NULL,
	[Lead] [varchar](50) NULL,
	[Remarks] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[IssueID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


