/*
   Thursday, May 13, 202110:39:07 AM
   User: 
   Server: .\
   Database: IRS_Scale
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Account ADD
	Email_Ticket bit NOT NULL CONSTRAINT DF_Account_Email_Ticket DEFAULT 0,
	Email nvarchar(255) NOT NULL CONSTRAINT DF_Account_Email DEFAULT N''
GO
ALTER TABLE dbo.Account SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
go
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Setup ADD
	AllowEmail bit NOT NULL CONSTRAINT DF_Setup_AllowEmail DEFAULT 0,
	SMTPServer nvarchar(100) NULL,
	SMTPPort int NULL,
	SMTPUser nvarchar(100) NULL,
	SMTPPass nvarchar(100) NULL,
	SMTPFromEmail nvarchar(255) NULL
GO
ALTER TABLE dbo.Setup SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
