/*
   Thursday, March 13, 20147:33:09 PM
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
CREATE TABLE dbo.Tmp_AvrDex
	(
	dexID int NOT NULL IDENTITY (1, 1),
	dexRace int NULL,
	dexAvg int NULL,
	dexAvgMod int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_AvrDex SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_AvrDex ON
GO
IF EXISTS(SELECT * FROM dbo.AvrDex)
	 EXEC('INSERT INTO dbo.Tmp_AvrDex (dexID, dexRace, dexAvg, dexAvgMod)
		SELECT dexID, CONVERT(int, dexRace), dexAvg, dexAvgMod FROM dbo.AvrDex WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_AvrDex OFF
GO
DROP TABLE dbo.AvrDex
GO
EXECUTE sp_rename N'dbo.Tmp_AvrDex', N'AvrDex', 'OBJECT' 
GO
ALTER TABLE dbo.AvrDex ADD CONSTRAINT
	PK__AvrDex__02C7819E103A2279 PRIMARY KEY CLUSTERED 
	(
	dexID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvrDex', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvrDex', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvrDex', 'Object', 'CONTROL') as Contr_Per 