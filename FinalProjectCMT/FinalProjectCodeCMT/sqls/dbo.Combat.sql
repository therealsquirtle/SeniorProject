CREATE TABLE [dbo].[Combat] (
    [Weapon]         VARCHAR (50) NULL,
    [AttackBonus]    INT          NULL,
    [Damage]         INT          NULL,
    [Critical]       INT          NULL,
    [RangeIncrement] INT          NULL,
    [type]           VARCHAR (50) NULL,
    [Notes/Ammo]     TEXT         NULL,
    [CharID]         INT          NULL,
    CONSTRAINT [FK_Combat_Character] FOREIGN KEY ([CharID]) REFERENCES [dbo].[Character] ([CharID])
);

