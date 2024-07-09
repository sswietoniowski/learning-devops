CREATE DATABASE podcasts
GO

USE podcasts
GO

CREATE TABLE Podcasts
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Title NVARCHAR(MAX) NOT NULL
)
GO

INSERT INTO Podcasts (Title)
VALUES 
('Unhandled Exception Podcast'),
('Developer Weekly Podcast'),
('The Stack Overflow Podcast'),
('The Hanselminutes Podcast'),
('The .NET Rocks Podcast'),
('The Azure Podcast'),
('The AWS Podcast'),
('The Rabbit Hole Podcast'),
('The .NET Core Podcast');
GO
