CREATE TABLE [dbo].[Course] (
    [Id]          INT  IDENTITY(1,1) NOT NULL,
    [Label]       VARCHAR (25) NOT NULL,
    [Description] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);