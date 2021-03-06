/*
   Saturday, April 19, 20142:38:25 PM
   User: 
   Server: SQUIRTLE-PC
   Database: DDchar
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
ALTER TABLE dbo.Combat ADD
	CharID int NULL
GO
ALTER TABLE dbo.Combat SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Combat', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Combat', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Combat', 'Object', 'CONTROL') as Contr_Per 