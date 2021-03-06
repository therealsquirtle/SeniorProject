/*
   Thursday, March 13, 20147:40:16 PM
   User: 
   Server: Squirtle-PC
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
ALTER TABLE dbo.Races SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Races', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Races', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Races', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.racialTraits ADD CONSTRAINT
	FK_racialTraits_Races FOREIGN KEY
	(
	RaceID
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.racialTraits SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.racialTraits', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.racialTraits', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.racialTraits', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_racialAdjust
	(
	AdjID int NOT NULL IDENTITY (1, 1),
	Race int NULL,
	favoredClass varchar(1) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_racialAdjust SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_racialAdjust ON
GO
IF EXISTS(SELECT * FROM dbo.racialAdjust)
	 EXEC('INSERT INTO dbo.Tmp_racialAdjust (AdjID, Race, favoredClass)
		SELECT AdjID, CONVERT(int, Race), favoredClass FROM dbo.racialAdjust WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_racialAdjust OFF
GO
DROP TABLE dbo.racialAdjust
GO
EXECUTE sp_rename N'dbo.Tmp_racialAdjust', N'racialAdjust', 'OBJECT' 
GO
ALTER TABLE dbo.racialAdjust ADD CONSTRAINT
	PK__racialAd__A065A852CA72C4F0 PRIMARY KEY CLUSTERED 
	(
	AdjID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.racialAdjust ADD CONSTRAINT
	FK_racialAdjust_Races FOREIGN KEY
	(
	Race
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.racialAdjust', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.racialAdjust', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.racialAdjust', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Character ADD CONSTRAINT
	FK_Character_Races FOREIGN KEY
	(
	raceID
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Character SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Character', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Character', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Character', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.AvrgDex ADD CONSTRAINT
	FK_AvrgDex_Races FOREIGN KEY
	(
	dexRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AvrgDex SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvrgDex', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvrgDex', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvrgDex', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.AvrDex ADD CONSTRAINT
	FK_AvrDex_Races FOREIGN KEY
	(
	dexRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AvrDex SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvrDex', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvrDex', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvrDex', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Avgwis ADD CONSTRAINT
	FK_Avgwis_Races FOREIGN KEY
	(
	wisRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Avgwis SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Avgwis', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Avgwis', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Avgwis', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.AvgStrength ADD CONSTRAINT
	FK_AvgStrength_Races FOREIGN KEY
	(
	strRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AvgStrength SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvgStrength', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvgStrength', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvgStrength', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.AvgInt ADD CONSTRAINT
	FK_AvgInt_Races FOREIGN KEY
	(
	IntRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AvgInt SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvgInt', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvgInt', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvgInt', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Avgcon ADD CONSTRAINT
	FK_Avgcon_Races FOREIGN KEY
	(
	conRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Avgcon SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Avgcon', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Avgcon', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Avgcon', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Avgchar ADD CONSTRAINT
	FK_Avgchar_Races FOREIGN KEY
	(
	charRace
	) REFERENCES dbo.Races
	(
	Raceid
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Avgchar SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Avgchar', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Avgchar', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Avgchar', 'Object', 'CONTROL') as Contr_Per 