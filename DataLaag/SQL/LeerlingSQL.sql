CREATE TABLE [dbo].[LeerlingSQL](
	Voornaam NVARCHAR(255) NOT NULL,
    FamilieNaam NVARCHAR(255) NOT NULL,
    Adres NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    RijksregisterNummer NVARCHAR(11) NOT NULL PRIMARY KEY,
    GeboorteDatum DATE NOT NULL,
    LeerJaar INT NOT NULL,
    KlasLokaal NVARCHAR(255) NOT NULL,
    Functie NVARCHAR(255) NOT NULL
);
