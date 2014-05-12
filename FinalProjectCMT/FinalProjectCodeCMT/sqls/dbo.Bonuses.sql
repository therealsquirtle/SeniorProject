CREATE TABLE [dbo].[Bonuses] (
    [BonusID]       INT         IDENTITY (1, 1) NOT NULL,
    [lvl]           INT         NULL,
    [XD]            INT         NULL,
    [CSMaxRanks]    INT         NULL,
    [CCMaxRanks]    INT         NULL,
    [Feat]          VARCHAR (1) NULL,
    [Abiltiy]       VARCHAR (1) NULL,
    [ScoreIncrease] INT         NULL,
    PRIMARY KEY CLUSTERED ([BonusID] ASC)
);

