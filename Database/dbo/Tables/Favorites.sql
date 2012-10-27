CREATE TABLE [dbo].[Favorites]
(
	[ContactID] INT NOT NULL , 
    [ProjectID] INT NOT NULL, 
    CONSTRAINT [PK_Favorites] PRIMARY KEY ([ContactID], [ProjectID]), 
    CONSTRAINT [FK_Favorites_Contact] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[Contacts]([ContactID]), 
    CONSTRAINT [FK_Favorites_Project] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Projects]([ProjectID])
)
