CREATE TABLE [dbo].[Player]
(
    [Id]         NVARCHAR(128)          NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName] VARCHAR(50) NOT NULL , 
    [NickName] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
	[BirthDay] DATETIME2 (7)  NOT NULL,
	[Email]    NVARCHAR (256) NOT NULL,
    [ConnectedSince] DATETIME2 (7)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Chat_ToAspNetUsers] FOREIGN KEY ([Id]) REFERENCES [AspNetUsers]([Id])
)
