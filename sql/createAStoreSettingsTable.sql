USE [AStore]
IF  NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = N'AStoreSettings')

BEGIN
CREATE TABLE [dbo].[AStoreSettings](
	[Key] [nvarchar](50) NULL,
	[ValueType] [int] NULL,
	[IntValue] [int] NULL,
	[StringValue] [nvarchar](50) NULL,
	[DateValue] [datetime] NULL,
	[DecimalValue] [decimal](18, 0) NULL
) ON [PRIMARY]
END