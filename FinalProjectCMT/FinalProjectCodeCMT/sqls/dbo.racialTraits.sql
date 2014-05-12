CREATE TABLE [dbo].[racialTraits] (
    [RTID]         INT         IDENTITY (1, 1) NOT NULL,
    [size]         VARCHAR (1) NULL,
    [speed]        VARCHAR (1) NULL,
    [extraFeat]    VARCHAR (1) NULL,
    [extraSkillPt] INT         NULL,
    [RaceID]       INT         NULL,
    PRIMARY KEY CLUSTERED ([RTID] ASC),
    CONSTRAINT [FK_racialTraits_Races] FOREIGN KEY ([RaceID]) REFERENCES [dbo].[Races] ([Raceid])
);

