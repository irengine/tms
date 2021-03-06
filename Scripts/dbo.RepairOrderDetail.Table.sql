/****** Object:  Table [dbo].[RepairOrderDetail]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RepairOrderDetail](
	[RepairOrderDetailID] [int] IDENTITY(1000,1) NOT NULL,
	[RepairOrderID] [int] NOT NULL,
	[RepairDate] [datetime2](7) NOT NULL,
	[OutboundOrderDetailID] [int] NULL,
	[ToolID] [int] NOT NULL,
	[RepairingQuantity] [numeric](10, 2) NOT NULL,
	[Quantity] [numeric](10, 2) NOT NULL,
	[ScrapQuantity] [numeric](10, 2) NOT NULL,
	[ScrapReason] [varchar](50) NULL,
	[UnitPrice] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_RepairOrderDetail] PRIMARY KEY CLUSTERED 
(
	[RepairOrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[RepairOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_RepairOrderDetail_OutboundOrderDetail] FOREIGN KEY([OutboundOrderDetailID])
REFERENCES [dbo].[OutboundOrderDetail] ([OutboundOrderDetailID])
GO
ALTER TABLE [dbo].[RepairOrderDetail] CHECK CONSTRAINT [FK_RepairOrderDetail_OutboundOrderDetail]
GO
ALTER TABLE [dbo].[RepairOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_RepairOrderDetail_RepairOrder] FOREIGN KEY([RepairOrderID])
REFERENCES [dbo].[RepairOrder] ([RepairOrderID])
GO
ALTER TABLE [dbo].[RepairOrderDetail] CHECK CONSTRAINT [FK_RepairOrderDetail_RepairOrder]
GO
ALTER TABLE [dbo].[RepairOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_RepairOrderDetail_Tool] FOREIGN KEY([ToolID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
ALTER TABLE [dbo].[RepairOrderDetail] CHECK CONSTRAINT [FK_RepairOrderDetail_Tool]
GO
ALTER TABLE [dbo].[RepairOrderDetail] ADD  CONSTRAINT [DF_RepairOrderDetail_RepairingQuantity]  DEFAULT ((0)) FOR [RepairingQuantity]
GO
ALTER TABLE [dbo].[RepairOrderDetail] ADD  CONSTRAINT [DF_RepairOrderDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[RepairOrderDetail] ADD  CONSTRAINT [DF_RepairOrderDetail_ScrapQuantity]  DEFAULT ((0)) FOR [ScrapQuantity]
GO
