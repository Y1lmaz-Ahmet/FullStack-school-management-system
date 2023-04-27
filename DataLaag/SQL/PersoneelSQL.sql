CREATE TABLE [dbo].[PersoneelSQL](
	Voornaam VARCHAR(255) NOT NULL,
	FamilieNaam VARCHAR(255) NOT NULL,
	Adres VARCHAR(255) NOT NULL,
	Email VARCHAR(255) NOT NULL,
	RijksregisterNummer CHAR(11) NOT NULL,
	GeboorteDatum DATE NOT NULL,
	Functie VARCHAR(255) NOT NULL,
	PRIMARY KEY (RijksregisterNummer)
);
