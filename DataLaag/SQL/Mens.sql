CREATE TABLE [dbo].[MensSQL](
	[Voornaam] VARCHAR(255) NOT NULL,
	[FamilieNaam] VARCHAR(255) NOT NULL,
	[Adres] VARCHAR(255) NOT NULL,
	[Email] VARCHAR(255) NOT NULL,
	[RijksregisterNummer] VARCHAR(255) NOT NULL PRIMARY KEY,
	[GeboorteDatum] DATE NOT NULL,
);
