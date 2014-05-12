CREATE TABLE [dbo].[Items] (
    [Item]     NCHAR (10) NULL,
    [CharID]   INT        NULL,
    [Location] NCHAR (10) NULL,
    [Weight]   NCHAR (10) NULL,
    CONSTRAINT [FK_Table_1_Character] FOREIGN KEY ([CharID]) REFERENCES [dbo].[Character] ([CharID])
);

