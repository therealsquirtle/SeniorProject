/*
   Thursday, March 13, 20147:33:31 PM
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
CREATE TABLE dbo.Tmp_AvgStrength
	(
	strId int NOT NULL,
	strRace int NULL,
	strAverage int NULL,
	strAverageMod int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_AvgStrength SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT * FROM dbo.AvgStrength)
	 EXEC('INSERT INTO dbo.Tmp_AvgStrength (strId, strRace, strAverage, strAverageMod)
		SELECT strId, CONVERT(int, strRace), strAverage, strAverageMod FROM dbo.AvgStrength WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.AvgStrength
GO
EXECUTE sp_rename N'dbo.Tmp_AvgStrength', N'AvgStrength', 'OBJECT' 
GO
ALTER TABLE dbo.AvgStrength ADD CONSTRAINT
	PK__AvgStren__ADB4A14798C1A242 PRIMARY KEY CLUSTERED 
	(
	strId
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvgStrength', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvgStrength', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvgStrength', 'Object', 'CONTROL') as Contr_Per 