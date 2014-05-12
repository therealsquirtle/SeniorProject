CREATE TABLE [dbo].[AvrgDex] (
    [dexID]     INT IDENTITY (1, 1) NOT NULL,
    [dexRace]   INT NULL,
    [dexAvg]    INT NULL,
    [dexAvgMod] INT NULL,
    CONSTRAINT [PK__AvrgDex__02C7819E875EDF0A] PRIMARY KEY CLUSTERED ([dexID] ASC),
    CONSTRAINT [FK_AvrgDex_Races] FOREIGN KEY ([dexRace]) REFERENCES [dbo].[Races] ([Raceid])
);

