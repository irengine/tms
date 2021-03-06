/****** Object:  Table [dbo].[OutboundOrder]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OutboundOrder](
	[OutboundOrderID] [int] IDENTITY(1000,1) NOT NULL,
	[OutboundDate] [datetime2](7) NOT NULL,
	[ClassType] [int] NOT NULL,
	[Version] [int] NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Job] [varchar](50) NULL,
	[JobPosition] [nvarchar](20) NULL,
	[JobType] [nvarchar](20) NULL,
	[Berth] [varchar](50) NULL,
	[Machine] [varchar](50) NULL,
	[Ship] [varchar](50) NULL,
	[Hatch] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[Quantity] [varchar](50) NULL,
	[Process] [varchar](50) NULL,
	[LastUpdatedBy] [int] NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_OutboundOrder] PRIMARY KEY CLUSTERED 
(
	[OutboundOrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[OutboundOrder]  WITH CHECK ADD  CONSTRAINT [FK_OutboundOrder_SystemUser] FOREIGN KEY([LastUpdatedBy])
REFERENCES [dbo].[SystemUser] ([SystemUserID])
GO
ALTER TABLE [dbo].[OutboundOrder] CHECK CONSTRAINT [FK_OutboundOrder_SystemUser]
GO
ALTER TABLE [dbo].[OutboundOrder]  WITH CHECK ADD  CONSTRAINT [FK_OutboundOrder_Unit] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[OutboundOrder] CHECK CONSTRAINT [FK_OutboundOrder_Unit]
GO
ALTER TABLE [dbo].[OutboundOrder] ADD  CONSTRAINT [DF_OutboundOrder_ClassType]  DEFAULT ((1)) FOR [ClassType]
GO
ALTER TABLE [dbo].[OutboundOrder] ADD  CONSTRAINT [DF_OutboundOrder_Version]  DEFAULT ((0)) FOR [Version]
GO
