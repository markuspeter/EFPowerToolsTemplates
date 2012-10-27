CREATE TABLE [dbo].[Projects] (
    [ProjectID]    INT           IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (50) NOT NULL,
    [CreatorID]    INT           NOT NULL,
    [MaintainerID] INT           NOT NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED ([ProjectID] ASC),
    CONSTRAINT [FK_Projects_Creator] FOREIGN KEY ([CreatorID]) REFERENCES [dbo].[Contacts] ([ContactID]),
    CONSTRAINT [FK_Projects_Maintainer] FOREIGN KEY ([MaintainerID]) REFERENCES [dbo].[Contacts] ([ContactID])
);

