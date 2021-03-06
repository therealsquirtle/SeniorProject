/*
   Thursday, March 13, 20147:34:39 PM
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
CREATE TABLE dbo.Tmp_Avgchar
	(
	charID int NOT NULL IDENTITY (1, 1),
	charRace int NULL,
	charAvg int NULL,
	charAvgMod int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Avgchar SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Avgchar ON
GO
IF EXISTS(SELECT * FROM dbo.Avgchar)
	 EXEC('INSERT INTO dbo.Tmp_Avgchar (charID, charRace, charAvg, charAvgMod)
		SELECT charID, CONVERT(int, charRace), charAvg, charAvgMod FROM dbo.Avgchar WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Avgchar OFF
GO
DROP TABLE dbo.Avgchar
GO
EXECUTE sp_rename N'dbo.Tmp_Avgchar', N'Avgchar', 'OBJECT' 
GO
ALTER TABLE dbo.Avgchar ADD CONSTRAINT
	PK__Avgchar__82E7F8DF61C889F7 PRIMARY KEY CLUSTERED 
	(
	charID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Avgchar', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Avgchar', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Avgchar', 'Object', 'CONTROL') as Contr_Per 