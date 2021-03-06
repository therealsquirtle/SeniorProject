/*
   Thursday, March 13, 20147:33:22 PM
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
CREATE TABLE dbo.Tmp_Avgwis
	(
	wisID int NOT NULL IDENTITY (1, 1),
	wisRace int NULL,
	wisAvg int NULL,
	wisAvgMod int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Avgwis SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Avgwis ON
GO
IF EXISTS(SELECT * FROM dbo.Avgwis)
	 EXEC('INSERT INTO dbo.Tmp_Avgwis (wisID, wisRace, wisAvg, wisAvgMod)
		SELECT wisID, CONVERT(int, wisRace), wisAvg, wisAvgMod FROM dbo.Avgwis WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Avgwis OFF
GO
DROP TABLE dbo.Avgwis
GO
EXECUTE sp_rename N'dbo.Tmp_Avgwis', N'Avgwis', 'OBJECT' 
GO
ALTER TABLE dbo.Avgwis ADD CONSTRAINT
	PK__Avgwis__F7DC7E85C3A01A22 PRIMARY KEY CLUSTERED 
	(
	wisID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Avgwis', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Avgwis', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Avgwis', 'Object', 'CONTROL') as Contr_Per 