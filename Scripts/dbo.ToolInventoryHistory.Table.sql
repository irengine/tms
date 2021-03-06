/****** Object:  Table [dbo].[ToolInventoryHistory]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToolInventoryHistory](
	[ToolInventoryHistoryID] [int] IDENTITY(1000,1) NOT NULL,
	[ToolInventoryHistoryDate] [datetime2](7) NOT NULL,
	[Account] [varchar](10) NOT NULL,
	[ToolID] [int] NOT NULL,
	[UnitPrice] [numeric](10, 2) NOT NULL,
	[Quantity] [numeric](10, 2) NOT NULL,
	[PurchaseOrderID] [int] NULL,
	[SupplyID] [int] NULL,
	[OutboundOrderID] [int] NULL,
	[OutboundOrderDetailID] [int] NULL,
	[InboundOrderID] [int] NULL,
	[InboundOrderDetailID] [int] NULL,
	[CustomerID] [int] NULL,
	[ScrapOrderID] [int] NULL,
	[ScrapOrderDetailID] [int] NULL,
	[RepairOrderID] [int] NULL,
	[RepairOrderDetailID] [int] NULL,
 CONSTRAINT [PK_ToolInventoryHistory] PRIMARY KEY CLUSTERED 
(
	[ToolInventoryHistoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_OutboundOrder] FOREIGN KEY([OutboundOrderID])
REFERENCES [dbo].[OutboundOrder] ([OutboundOrderID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_OutboundOrder]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_OutboundOrderDetail] FOREIGN KEY([OutboundOrderDetailID])
REFERENCES [dbo].[OutboundOrderDetail] ([OutboundOrderDetailID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_OutboundOrderDetail]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_PurchaseOrder] FOREIGN KEY([PurchaseOrderID])
REFERENCES [dbo].[PurchaseOrder] ([PurchaseOrderID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_PurchaseOrder]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_Supply] FOREIGN KEY([SupplyID])
REFERENCES [dbo].[Supply] ([SupplyID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_Supply]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_Tool] FOREIGN KEY([ToolID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_Tool]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_Unit] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_Unit]
GO
ALTER TABLE [dbo].[ToolInventoryHistory] ADD  CONSTRAINT [DF_ToolInventoryHistory_ToolInventoryHistoryDate]  DEFAULT (getdate()) FOR [ToolInventoryHistoryDate]
GO
ALTER TABLE [dbo].[ToolInventoryHistory] ADD  CONSTRAINT [DF_ToolInventoryHistory_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[ToolInventoryHistory] ADD  CONSTRAINT [DF_ToolInventoryHistory_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_InboundOrder] FOREIGN KEY([InboundOrderID])
REFERENCES [dbo].[InboundOrder] ([InboundOrderID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_InboundOrder]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_InboundOrderDetail] FOREIGN KEY([InboundOrderDetailID])
REFERENCES [dbo].[InboundOrderDetail] ([InboundOrderDetailID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_InboundOrderDetail]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_RepairOrder] FOREIGN KEY([RepairOrderID])
REFERENCES [dbo].[RepairOrder] ([RepairOrderID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_RepairOrder]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_RepairOrderDetail] FOREIGN KEY([RepairOrderDetailID])
REFERENCES [dbo].[RepairOrderDetail] ([RepairOrderDetailID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_RepairOrderDetail]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_ScrapOrder] FOREIGN KEY([ScrapOrderID])
REFERENCES [dbo].[ScrapOrder] ([ScrapOrderID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_ScrapOrder]
GO
ALTER TABLE [dbo].[ToolInventoryHistory]  WITH CHECK ADD  CONSTRAINT [FK_ToolInventoryHistory_ScrapOrderDetail] FOREIGN KEY([ScrapOrderDetailID])
REFERENCES [dbo].[ScrapOrderDetail] ([ScrapOrderDetailID])
GO
ALTER TABLE [dbo].[ToolInventoryHistory] CHECK CONSTRAINT [FK_ToolInventoryHistory_ScrapOrderDetail]
GO