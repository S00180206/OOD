CREATE TABLE [dbo].[Authors] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL DEFAULT 1,
    [Name] NVARCHAR (MAX) NOT NULL DEFAULT john,
    CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED ([Id] ASC)
);

