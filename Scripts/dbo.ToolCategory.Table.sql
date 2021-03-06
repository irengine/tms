/****** Object:  Table [dbo].[ToolCategory]    Script Date: 11/09/2010 09:53:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ToolCategory](
	[ToolCategoryID] [int] IDENTITY(1000,1) NOT NULL,
	[Code] [varchar](20) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[ParentCategoryID] [int] NULL,
 CONSTRAINT [PK_ToolCategory] PRIMARY KEY CLUSTERED 
(
	[ToolCategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ToolCategory]  WITH CHECK ADD  CONSTRAINT [FK_ChildCategory_ParentCategory] FOREIGN KEY([ParentCategoryID])
REFERENCES [dbo].[ToolCategory] ([ToolCategoryID])
GO
ALTER TABLE [dbo].[ToolCategory] CHECK CONSTRAINT [FK_ChildCategory_ParentCategory]
GO
ALTER TABLE [dbo].[ToolCategory] ADD  CONSTRAINT [DF_ToolCategory_Deleted]  DEFAULT ((0)) FOR [Deleted]
GO
