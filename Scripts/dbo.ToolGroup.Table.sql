/****** Object:  Table [dbo].[ToolGroup]    Script Date: 11/13/2010 10:28:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ToolGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ToolGroup](
	[ToolGroupID] [int] NOT NULL,
	[ToolID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ToolGroup] PRIMARY KEY CLUSTERED 
(
	[ToolGroupID] ASC,
	[ToolID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  ForeignKey [FK_ToolGroup_Tool]    Script Date: 11/13/2010 10:28:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ToolGroup_Tool]') AND parent_object_id = OBJECT_ID(N'[dbo].[ToolGroup]'))
ALTER TABLE [dbo].[ToolGroup]  WITH CHECK ADD  CONSTRAINT [FK_ToolGroup_Tool] FOREIGN KEY([ToolGroupID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ToolGroup_Tool]') AND parent_object_id = OBJECT_ID(N'[dbo].[ToolGroup]'))
ALTER TABLE [dbo].[ToolGroup] CHECK CONSTRAINT [FK_ToolGroup_Tool]
GO
/****** Object:  ForeignKey [FK_ToolGroup_Tool2]    Script Date: 11/13/2010 10:28:54 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ToolGroup_Tool2]') AND parent_object_id = OBJECT_ID(N'[dbo].[ToolGroup]'))
ALTER TABLE [dbo].[ToolGroup]  WITH CHECK ADD  CONSTRAINT [FK_ToolGroup_Tool2] FOREIGN KEY([ToolID])
REFERENCES [dbo].[Tool] ([ToolID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ToolGroup_Tool2]') AND parent_object_id = OBJECT_ID(N'[dbo].[ToolGroup]'))
ALTER TABLE [dbo].[ToolGroup] CHECK CONSTRAINT [FK_ToolGroup_Tool2]
GO

