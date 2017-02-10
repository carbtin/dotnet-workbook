CREATE TABLE [dbo].[Student] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [fName]    VARCHAR (25) NOT NULL,
    [lName]    VARCHAR (50) NULL,
    [CourseId] INT          NOT NULL,
    [EnrollmentDate] DateTime NOT NULL,
    
    CONSTRAINT [FK_Student_Course] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([Id])
);

