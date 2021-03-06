/*
   Saturday, April 19, 20145:22:43 PM
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
ALTER TABLE dbo.Character SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Character', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Character', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Character', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Combat ADD CONSTRAINT
	FK_Combat_Character FOREIGN KEY
	(
	CharID
	) REFERENCES dbo.Character
	(
	CharID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Combat SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Combat', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Combat', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Combat', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	Item nchar(10) NULL,
	CharID int NULL,
	Location nchar(10) NULL,
	Weight nchar(10) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 ADD CONSTRAINT
	FK_Table_1_Character FOREIGN KEY
	(
	CharID
	) REFERENCES dbo.Character
	(
	CharID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Table_1', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Table_1', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Table_1', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Abilities ADD CONSTRAINT
	FK_Abilities_Character FOREIGN KEY
	(
	CharID
	) REFERENCES dbo.Character
	(
	CharID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Abilities SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Abilities', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Abilities', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Abilities', 'Object', 'CONTROL') as Contr_Per 