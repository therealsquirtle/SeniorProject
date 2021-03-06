/*
   Thursday, March 13, 20147:31:44 PM
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
CREATE TABLE dbo.Tmp_Character
	(
	CharID int NOT NULL IDENTITY (1, 1),
	name varchar(1) NULL,
	Pname varchar(1) NULL,
	class varchar(1) NULL,
	raceID int NULL,
	clevel int NULL,
	ECL int NULL,
	Size varchar(1) NULL,
	gender varchar(1) NULL,
	alignment varchar(1) NULL,
	religon varchar(1) NULL,
	height int NULL,
	cweight int NULL,
	cdescription varchar(1) NULL,
	photo image NULL,
	touchAc int NULL,
	flatAC int NULL,
	hitPoints int NULL,
	experiencePoints int NULL,
	lightCarry int NULL,
	medCarry int NULL,
	heavyCarry int NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Character SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Character ON
GO
IF EXISTS(SELECT * FROM dbo.Character)
	 EXEC('INSERT INTO dbo.Tmp_Character (CharID, name, Pname, class, raceID, clevel, ECL, Size, gender, alignment, religon, height, cweight, cdescription, photo, touchAc, flatAC, hitPoints, experiencePoints, lightCarry, medCarry, heavyCarry)
		SELECT CharID, name, Pname, class, CONVERT(int, race), clevel, ECL, Size, gender, alignment, religon, height, cweight, cdescription, photo, touchAc, flatAC, hitPoints, experiencePoints, lightCarry, medCarry, heavyCarry FROM dbo.Character WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Character OFF
GO
DROP TABLE dbo.Character
GO
EXECUTE sp_rename N'dbo.Tmp_Character', N'Character', 'OBJECT' 
GO
ALTER TABLE dbo.Character ADD CONSTRAINT
	PK__Characte__AA7BC254B1A395A7 PRIMARY KEY CLUSTERED 
	(
	CharID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Character', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Character', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Character', 'Object', 'CONTROL') as Contr_Per 