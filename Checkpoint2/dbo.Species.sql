CREATE TABLE [dbo].[Species] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
	[EntityId]  INT NOT NULL,
	[SciName] VARCHAR (100) NULL,
	[ComName] VARCHAR (100) NULL,
	[StatusId] INT NOT NULL,
	[SpCode] VARCHAR (20) NULL,
	[VipCode] VARCHAR (20) NULL,
	[PopAbbrev] VARCHAR (MAX) NULL,
	[PopDesc] VARCHAR (MAX) NULL,
	[TSN] INT NOT NULL,
	[CountryId] INT NOT NULL,
	[ListingDate] DateTime NOT NULL,
--    CONSTRAINT [FK_Student_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id])
)

