USE [TMS]
GO

/****** Object:  Table [dbo].[Job]    Script Date: 06/20/2011 17:24:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Job](
	[JobID] [int] IDENTITY(1000,1) NOT NULL,
	[JobCode] [varchar](50) NULL,
	[JobPosition] [nvarchar](20) NULL,
	[JobType] [nvarchar](20) NULL,
	[Berth] [varchar](50) NULL,
	[Machine] [varchar](50) NULL,
	[Ship] [varchar](50) NULL,
	[Hatch] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[Quantity] [varchar](50) NULL,
	[Process] [varchar](50) NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

