using BusinessLaag.exceptions;
using BusinessLaag.klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesten
{
    public class UnitLeerling
    {
        [Fact]
        public void Test_Ctr_Valid_Leerling()
        {
            string voornaam = "Ahmet";
            string familieNaam = "Yilmaz";
            string adres = "Moertstraat 16w2";
            string email = "ahmet.79@hotmail.be";
            string rijksregisternummer = "11111111111";//11 digits
            DateTime geboorteDatum = new DateTime(1998, 12, 07);
            int leerljaar = 2;
            string klasLokaal = "b";

            Leerling leerling = new Leerling(voornaam,familieNaam,adres,email,rijksregisternummer,geboorteDatum,leerljaar,klasLokaal);
            Assert.Equal(voornaam, leerling.Voornaam);
            Assert.Equal(familieNaam, leerling.FamilieNaam);
            Assert.Equal(adres, leerling.Adres);
            Assert.Equal(email,leerling.Email);
            Assert.Equal(rijksregisternummer, leerling.RijksregisterNummer);
            Assert.Equal(geboorteDatum,leerling.GeboorteDatum);
            Assert.Equal(leerljaar, leerling.LeerJaar);
            Assert.Equal(klasLokaal, leerling.KlasLokaal);
            Assert.IsType<Leerling>(leerling);
        }
        [Theory]
        [NullOrWhitespaceData]
        public void Test_Ctr_Invalid_Voornaam_Leerling(string voornaam)
        {
            Leerling l;
            var ex = Assert.Throws<MensException>(() => l = new Leerling(voornaam, "yilmaz", "moerstraat", "ahmet.79@hotmail.be", "12345678911", new DateTime(1998, 07, 12), 6, "b"));
            Assert.Equal("Naam mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [NullOrWhitespaceData]
        public void Test_Invalid_Familienaam_Leerling(string familienaam)
        {
            Leerling l;
            var ex = Assert.Throws<MensException>(() => l = new Leerling("ahmet", familienaam, "moerstraat", "ahmet.79@hotmail.be", "12345678911", new DateTime(1998, 07, 12), 6, "b"));
            Assert.Equal("Familienaam mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [NullOrWhitespaceData]
        public void Test_Invalid_Adres_Leerling(string adres)
        {
            Leerling l;
            var ex = Assert.Throws<MensException>(() => l = new Leerling("ahmet", "yilmaz", adres, "ahmet.79@hotmail.be", "12345678911", new DateTime(1998, 07, 12), 6, "b"));
            Assert.Equal("Adres mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [NullOrWhitespaceData]
        public void Test_Invalid_Email_Leerling(string email)
        {
            Leerling l;
            var ex = Assert.Throws<MensException>(() => l = new Leerling("ahmet", "YILMAAZZZZ", "moerstraat", email, "12345678911", new DateTime(1998, 07, 12), 6, "b"));
            Assert.Equal("Email mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [NullOrWhitespaceData]
        [InlineData("1234567891")]
        [InlineData("123456789111")]
        public void Test_Invalid_RijksregisterNummer_Leerling(string rijksregisterNummer)
        {
            Leerling l;
            var ex = Assert.Throws<MensException>(() => l = new Leerling("ahmet", "YILMAAZZZZ", "moerstraat", "email@email.be", rijksregisterNummer, new DateTime(1998, 07, 12), 6, "b"));
            Assert.Equal("Een rijksregisternummer bestaat uit 11 tekens en mag niet leeg zijn.", ex.Message);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Test_Ctr_Invalid_Leerjaar_Leerling(int leerljaar)
        {
            Leerling l;
            var ex = Assert.Throws<LeerlingException>(() => l = new Leerling("ahmet", "yilmaz", "moerstraat", "ahmet.79@hotmail.be", "12345678911", new DateTime(1998, 07, 12),leerljaar, "b"));
            Assert.Equal("Leerjaar kan niet 0 zijn.",ex.Message);
        }
        [Theory]
        [NullOrWhitespaceData]
        public void Test_Ctr_Invalid_Klaslokaal_Leerling(string klaslokaal)
        {
            Leerling l;
            var ex = Assert.Throws<LeerlingException>(() => l = new Leerling("ahmet", "yilmaz", "moerstraat", "ahmet.79@hotmail.be", "12345678911", new DateTime(1998, 07, 12), 5, klaslokaal));
            Assert.Equal("Klaslokaal mag niet leeg zijn.", ex.Message);
        }



    }
}
