drop Table [dbo].[KHACHHANG]
go
SET ANSI_PADDING ON
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [char](10) NOT NULL,
	[TENKH] [nvarchar](50) NULL,
	[SDTKH] [char](13) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[CMND] [char](10) NULL,
	[QUOCTICH] [nvarchar](20) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_0317FA22A0584307B413481E1643FF8D]  DEFAULT (newsequentialid())
)

GO
SET ANSI_NULLS ON

go

SET QUOTED_IDENTIFIER ON

go

