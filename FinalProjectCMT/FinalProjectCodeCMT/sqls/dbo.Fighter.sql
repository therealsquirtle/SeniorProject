CREATE TABLE [dbo].[Fighter] (
    [classID]       INT IDENTITY (1, 1) NOT NULL,
    [FLvl]          INT NULL,
    [FBaseAttckBon] INT NULL,
    [FFortSave]     INT NULL,
    [FWillSave]     INT NULL,
    [FSpecial]      INT NULL,
    PRIMARY KEY CLUSTERED ([classID] ASC),
    CONSTRAINT [FK_Fighter_Classes] FOREIGN KEY ([classID]) REFERENCES [dbo].[Classes] ([classID])
);

