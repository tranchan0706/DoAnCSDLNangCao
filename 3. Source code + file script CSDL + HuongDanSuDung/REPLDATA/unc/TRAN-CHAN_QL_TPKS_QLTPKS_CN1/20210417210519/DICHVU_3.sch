drop Table [dbo].[DICHVU]
go
SET ANSI_PADDING ON
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MADV] [char](10) NOT NULL,
	[TENDV] [nvarchar](50) NULL,
	[GIADV] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_3EDB95FDA5764647A89D6D06004CB3DB]  DEFAULT (newsequentialid())
)

GO
SET ANSI_NULLS ON

go

SET QUOTED_IDENTIFIER ON

go

