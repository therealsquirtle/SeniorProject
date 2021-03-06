/*
   Thursday, March 13, 20147:33:41 PM
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
CREATE TABLE dbo.Tmp_AvgInt
	(
	IntID int NOT NULL IDENTITY (1, 1),
	IntRace int NULL,
	IntAvg int NULL,
	IntAvgMod int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_AvgInt SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_AvgInt ON
GO
IF EXISTS(SELECT * FROM dbo.AvgInt)
	 EXEC('INSERT INTO dbo.Tmp_AvgInt (IntID, IntRace, IntAvg, IntAvgMod)
		SELECT IntID, CONVERT(int, IntRace), IntAvg, IntAvgMod FROM dbo.AvgInt WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_AvgInt OFF
GO
DROP TABLE dbo.AvgInt
GO
EXECUTE sp_rename N'dbo.Tmp_AvgInt', N'AvgInt', 'OBJECT' 
GO
ALTER TABLE dbo.AvgInt ADD CONSTRAINT
	PK__AvgInt__9E544796CD28AA85 PRIMARY KEY CLUSTERED 
	(
	IntID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.AvgInt', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.AvgInt', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.AvgInt', 'Object', 'CONTROL') as Contr_Per 