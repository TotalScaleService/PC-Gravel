/*
   Tuesday, February 09, 201611:06:17 AM
   User: sa
   Server: MATT-LAPTOP\SQLEXPRESS
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
ALTER TABLE dbo.Transactions ADD
	Driver_Name varchar(50) NULL
GO
ALTER TABLE dbo.Trucks ADD
        Driver_Name varchar(50) NULL
GO

ALTER TABLE dbo.Transactions SET (LOCK_ESCALATION = TABLE)
GO

COMMIT
