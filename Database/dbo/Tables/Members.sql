CREATE TABLE [dbo].[Members] (
    [ContactID] INT           NOT NULL,
    [ProjectID] INT           NOT NULL,
    [JoinedOn]  SMALLDATETIME NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([ContactID] ASC, [ProjectID] ASC),
    CONSTRAINT [FK_Members_Contact] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[Contacts] ([ContactID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Members_Project] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Projects] ([ProjectID]) ON DELETE CASCADE
);

