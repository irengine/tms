/****** Object:  Table [dbo].[RepairOrder]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RepairOrder](
	[RepairOrderID] [int] IDENTITY(1000,1) NOT NULL,
	[RepairDate] [datetime2](7) NOT NULL,
	[OutboundOrderID] [int] NULL,
	[Code] [varchar](20) NOT NULL,
	[CustomerID] [int] NULL,
	[Status] [int] NOT NULL,
	[LastUpdatedBy] [int] NOT NULL,
	[LastUpdateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_RepairOrder] PRIMARY KEY CLUSTERED 
(
	[RepairOrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[RepairOrder]  WITH CHECK ADD  CONSTRAINT [FK_RepairOrder_OutboundOrder] FOREIGN KEY([OutboundOrderID])
REFERENCES [dbo].[OutboundOrder] ([OutboundOrderID])
GO
ALTER TABLE [dbo].[RepairOrder] CHECK CONSTRAINT [FK_RepairOrder_OutboundOrder]
GO
ALTER TABLE [dbo].[RepairOrder]  WITH CHECK ADD  CONSTRAINT [FK_RepairOrder_SystemUser] FOREIGN KEY([LastUpdatedBy])
REFERENCES [dbo].[SystemUser] ([SystemUserID])
GO
ALTER TABLE [dbo].[RepairOrder] CHECK CONSTRAINT [FK_RepairOrder_SystemUser]
GO
ALTER TABLE [dbo].[RepairOrder]  WITH CHECK ADD  CONSTRAINT [FK_RepairOrder_Unit] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[RepairOrder] CHECK CONSTRAINT [FK_RepairOrder_Unit]
GO
ALTER TABLE [dbo].[RepairOrder] ADD  CONSTRAINT [DF_RepairOrder_Status]  DEFAULT ((0)) FOR [Status]
GO
