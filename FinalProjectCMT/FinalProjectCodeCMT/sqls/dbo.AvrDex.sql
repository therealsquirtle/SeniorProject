CREATE TABLE [dbo].[AvrDex] (
    [dexID]     INT IDENTITY (1, 1) NOT NULL,
    [dexRace]   INT NULL,
    [dexAvg]    INT NULL,
    [dexAvgMod] INT NULL,
    CONSTRAINT [PK__AvrDex__02C7819E103A2279] PRIMARY KEY CLUSTERED ([dexID] ASC),
    CONSTRAINT [FK_AvrDex_Races] FOREIGN KEY ([dexRace]) REFERENCES [dbo].[Races] ([Raceid])
);

