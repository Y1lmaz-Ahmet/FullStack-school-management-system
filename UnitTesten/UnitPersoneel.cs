using BusinessLaag.exceptions;
using BusinessLaag.klassen;

namespace UnitTesten
{
    public class UnitPersoneel
    {
        [Fact]
        public void Test_ctr_Valid_Personeel()
        {
            string voornaam = "Ahmet";
            string familieNaam = "Yilmaz";
            string adres = "Moertstraat 16w2";
            string email = "ahmet.79@hotmail.be";
            string rijksregisternummer = "12345678911";//11 digits
            DateTime geboorteDatum = new DateTime(1998, 12, 07);
            
            Personeel personeel = new Personeel(voornaam,familieNaam,adres, email,rijksregisternummer,geboorteDatum,"Personeel");
            Assert.Equal(voornaam, personeel.Voornaam);
            Assert.Equal(familieNaam , personeel.FamilieNaam);
            Assert.Equal(adres, personeel.Adres);
            Assert.Equal(rijksregisternummer, personeel.RijksregisterNummer);
            Assert.Equal(geboorteDatum , personeel.GeboorteDatum);
        }
        [Theory]
        [InlineData("Jan", "Janssen", "Steenweg 1", "jan.janssen@test.be", "12345678911", 1998,12,07, "personeel")]
        [InlineData("Piet", "Pietersen", "Hoofdstraat 1", "piet.pietersen@test.be", "12345678911", 1990, 5, 15, "personeel")]
        [InlineData("Kees", "Keesen", "Dorpstraat 2", "kees.keesen@test.be", "12345678911", 1985, 9, 30, "manager")]
        [InlineData("Anne", "Annesen", "Kerkweg 3", "anne.annesen@test.be", "12345678911", 1993, 2, 14, "personeel")]
        [InlineData("Sander", "Sandersen", "Schoolstraat 4", "sander.sandersen@test.be", "12345678911", 1988, 11, 22, "personeel")]
        [InlineData("Marieke", "Mariekesen", "Industrieweg 5", "marieke.mariekesen@test.be", "12345678911", 1995, 7, 7, "manager")]
        [InlineData("Bram", "Bramsen", "Burgemeesterstraat 6", "bram.bramsen@test.be", "12345678911", 1983, 12, 31, "personeel")]
        [InlineData("Lisa", "Lisabethsen", "Valkenlaan 7", "lisa.lisabethsen@test.be", "12345678911", 1992, 4, 1, "manager")]
        public void Test_ctr_Valid_withTheory_Personeel(string voornaam, string familieNaam, string adres, string email,
            string rijksregisternummer, int geboorteJaar, int geboorteMaand, int geboorteDag, string functie)
        {
            Personeel personeel = new Personeel(voornaam, familieNaam, adres, email, rijksregisternummer, new DateTime(geboorteJaar, geboorteMaand, geboorteDag), functie);
            // Verifieer de eigenschappen van de Personeel object
            Assert.Equal(voornaam,personeel.Voornaam);
            Assert.Equal(familieNaam,personeel.FamilieNaam);
            Assert.Equal(adres,personeel.Adres);
            Assert.Equal(email, personeel.Email);
            Assert.Equal(rijksregisternummer, personeel.RijksregisterNummer);
            Assert.Equal(new DateTime(geboorteJaar, geboorteMaand, geboorteDag), personeel.GeboorteDatum);
            Assert.Equal(functie, personeel.Functie);
        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData(null)]
        public void Test_ctr_invalid_voornaam_Personeel(string voornaam)
        {
            Personeel p;
            var ex = Assert.Throws<MensException>(() => p = new Personeel(voornaam, "Janssen", "Steenweg 1", "jan.janssen@test.be",
                "12345678911",new DateTime(1998,12,7), "personeel"));
            Assert.Equal("Naam mag niet leeg zijn.", ex.Message);
        }
        [Fact]
        public void Test_ctr_invalid_withEmptyVoornaam_Personeel_ThrowsMensException()
        {
            // Arrange
            string voornaam = "";
            string familieNaam = "Janssen";
            string adres = "Steenweg 1";
            string email = "jan.janssen@test.be";
            string rijksregisterNummer = "12345678911";
            DateTime geboorteDatum = new DateTime(1998, 12, 7);

            // Act & Assert
            Assert.Throws<MensException>(() => new Personeel(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum, "personeel"));
        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData(null)]
        public void Test_ctr_invalid_familieNaam_Personeel(string familieNaam)
        {
            Personeel p;
            var ex = Assert.Throws<MensException>(() => p = new Personeel("Jan", familieNaam, "Steenweg 1", "jan.janssen@test.be",
                "12345678911", new DateTime(1998, 12, 7), "personeel"));
            Assert.Equal("Familienaam mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData(null)]
        public void Test_ctr_invalid_adres_Personeel(string adres)
        {
            Personeel p;
            var ex = Assert.Throws<MensException>(() => p = new Personeel("Jan", "yilmaz", adres, "jan.janssen@test.be",
                "12345678911", new DateTime(1998, 12, 7), "personeel"));
            Assert.Equal("Adres mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("\n")]
        [InlineData("\t")]
        [InlineData(null)]
        public void Test_ctr_invalid_email_Personeel(string email)
        {
            Personeel p;
            var ex = Assert.Throws<MensException>(() => p = new Personeel("Jan", "yilmaz", "moerstraat 16w2", email, "12345678911", new DateTime(1998, 12, 7), "personeel"));
            Assert.Equal("Email mag niet leeg zijn.", ex.Message);
        }

        [Theory]
        [InlineData("123456789111")]
        [InlineData("1234567891")]
        public void Test_Ctr_Invalid_RijksregisterNummer_Personeel(string rijksregisterNummer)
        {
            Personeel p;
            var ex = Assert.Throws<MensException>(() => p = new Personeel("Jan", "yilmaz", "moerstraat 16w2", "ahmet@hotmail.be", rijksregisterNummer, new DateTime(1998, 12, 7), "personeel"));
            Assert.Equal("Een rijksregisternummer bestaat uit 11 tekens en mag niet leeg zijn.", ex.Message);
        }
        [Fact]
        public void Test_ctr_invalid_geboorteDatum_Personeel()
        {
            // Arrange
            string voornaam = "Jan";
            string familieNaam = "Janssen";
            string adres = "Steenweg 1";
            string email = "jan.janssen@test.be";
            string rijksregisterNummer = "12345678911";
            DateTime geboorteDatum = DateTime.MaxValue;

            // Act & Assert
            Assert.Throws<MensException>(() => new Personeel(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum, "personeel"));
        }




    }
}