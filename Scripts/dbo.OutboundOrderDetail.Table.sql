/****** Object:  Table [dbo].[OutboundOrderDetail]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutboundOrderDetail](
	[OutboundOrderDetailID] [int] IDENTITY(1000,1) NOT NULL,
	[OutboundOrderID] [int] NOT NULL,
	[OutboundDate] [datetime2](7) NOT NULL,
	[Version] [int] NOT NULL,
	[ToolID] [int] NOT NULL,
	[UnitPrice] [numeric](10, 2) NOT NULL,
	[Quantity] [numeric](10, 2) NOT NULL,
	[Balance] [numeric](10, 2) NOT NULL,
	[Description][text] NULL,
 CONSTRAINT [PK_OutboundOrderDetail] PRIMARY KEY CLUSTERED 
(
	[OutboundOrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OutboundOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OutboundOrderDetail_OutboundOrder] FOREIGN KEY([OutboundOrderID])
REFERENCES [dbo].[OutboundOrder] ([OutboundOrderID])
GO
ALTER TABLE [dbo].[OutboundOrderDetail] CHECK CONSTRAINT [FK_OutboundOrderDetail_OutboundOrder]
GO
ALTER TABLE [dbo].[OutboundOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OutboundOrderDetail_Tool] FOREIGN KEY([ToolID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
ALTER TABLE [dbo].[OutboundOrderDetail] CHECK CONSTRAINT [FK_OutboundOrderDetail_Tool]
GO
ALTER TABLE [dbo].[OutboundOrderDetail] ADD  CONSTRAINT [DF_OutboundOrderDetail_Version]  DEFAULT ((0)) FOR [Version]
GO
ALTER TABLE [dbo].[OutboundOrderDetail] ADD  CONSTRAINT [DF_OutboundOrderDetail_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[OutboundOrderDetail] ADD  CONSTRAINT [DF_OutboundOrderDetail_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[OutboundOrderDetail] ADD  CONSTRAINT [DF_OutboundOrderDetail_Balance]  DEFAULT ((0)) FOR [Balance]
GO