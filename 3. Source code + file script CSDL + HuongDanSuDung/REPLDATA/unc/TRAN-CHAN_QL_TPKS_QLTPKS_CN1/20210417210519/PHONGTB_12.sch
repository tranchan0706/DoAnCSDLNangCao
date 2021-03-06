drop Table [dbo].[PHONGTB]
go
SET ANSI_PADDING ON
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGTB](
	[MATB] [char](10) NOT NULL,
	[MAPHONG] [char](10) NOT NULL,
	[TINHTRANG] [nvarchar](50) NULL,
	[GHICHU] [nvarchar](100) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_B7EC5368F0374F478BA0B9E9593E71E7]  DEFAULT (newsequentialid())
)

GO
SET ANSI_NULLS ON

go

SET QUOTED_IDENTIFIER ON

go

SET ANSI_PADDING ON

GO
ALTER TABLE [dbo].[PHONGTB] ADD  CONSTRAINT [PK_PHONGTB] PRIMARY KEY CLUSTERED 
(
	[MATB] ASC,
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO
