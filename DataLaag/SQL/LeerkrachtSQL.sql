CREATE TABLE [dbo].[LeerkrachtSQL](
	Voornaam NVARCHAR(255) NOT NULL,
    FamilieNaam NVARCHAR(255) NOT NULL,
    Adres NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    RijksregisterNummer CHAR(11) NOT NULL,
    GeboorteDatum DATE NOT NULL,
    Functie NVARCHAR(255) NOT NULL,
    Vakken NVARCHAR(MAX) NOT NULL,
    WerknemerType INT NOT NULL,
    CONSTRAINT PK_Leerkracht PRIMARY KEY (RijksregisterNummer)
);
