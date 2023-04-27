CREATE TABLE [dbo].[AdministratiefMedewerkerSQL](
PersoneelID INT PRIMARY KEY,
    Voornaam VARCHAR(50) NOT NULL,
    Familienaam VARCHAR(50) NOT NULL,
    Adres VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    RijksregisterNummer VARCHAR(11) NOT NULL,
    GeboorteDatum DATE NOT NULL,
    WerknemerType INT NOT NULL,
    Functie VARCHAR(50) NOT NULL
    );