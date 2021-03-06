/*
   Thursday, March 13, 20147:34:31 PM
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
CREATE TABLE dbo.Tmp_Avgcon
	(
	conID int NOT NULL IDENTITY (1, 1),
	conRace int NULL,
	conAvg int NULL,
	conAvgMod int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Avgcon SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Avgcon ON
GO
IF EXISTS(SELECT * FROM dbo.Avgcon)
	 EXEC('INSERT INTO dbo.Tmp_Avgcon (conID, conRace, conAvg, conAvgMod)
		SELECT conID, CONVERT(int, conRace), conAvg, conAvgMod FROM dbo.Avgcon WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Avgcon OFF
GO
DROP TABLE dbo.Avgcon
GO
EXECUTE sp_rename N'dbo.Tmp_Avgcon', N'Avgcon', 'OBJECT' 
GO
ALTER TABLE dbo.Avgcon ADD CONSTRAINT
	PK__Avgcon__908C8C2B2177012A PRIMARY KEY CLUSTERED 
	(
	conID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Avgcon', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Avgcon', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Avgcon', 'Object', 'CONTROL') as Contr_Per 