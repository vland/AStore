USE [AStore]
IF  NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_NAME = N'Contacts')

BEGIN
CREATE TABLE [dbo].[Contacts](
	[ID] [uniqueidentifier] NOT NULL,
	[Address] [nvarchar](50) NULL,
	[Phone1] [nvarchar](50) NULL,
	[Phone2] [nvarchar](50) NULL,
	[WorkingTimeStart] [time](7) NULL,
	[WorkingTimeEnd] [time](7) NULL
) ON [PRIMARY]
END