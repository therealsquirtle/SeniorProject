CREATE TABLE [dbo].[racialAdjust] (
    [AdjID]        INT         IDENTITY (1, 1) NOT NULL,
    [Race]         INT         NULL,
    [favoredClass] VARCHAR (1) NULL,
    CONSTRAINT [PK__racialAd__A065A852CA72C4F0] PRIMARY KEY CLUSTERED ([AdjID] ASC),
    CONSTRAINT [FK_racialAdjust_Races] FOREIGN KEY ([Race]) REFERENCES [dbo].[Races] ([Raceid])
);

