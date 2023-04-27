using BusinessLaag.Enums;
using BusinessLaag.exceptions;
using BusinessLaag.klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesten
{
    public class UnitLeerkracht
    {
        [Fact]
        public void Leerkracht_CorrecteInput_CreatesObject()
        {
            // Arrange
            var voornaam = "John";
            var familieNaam = "Doe";
            var adres = "Kerkstraat 1";
            var email = "john.doe@example.com";
            var rijksregisterNummer = "99010112345";
            var geboorteDatum = new DateTime(1999, 01, 01);
            var vakken = new List<string> { "Wiskunde", "Nederlands" };
            var werknemerType = WerknemerType.Fulltime;

            // Act
            var leerkracht = new Leerkracht(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum, vakken, werknemerType);

            // Assert
            Assert.NotNull(leerkracht);
            Assert.IsType<Leerkracht>(leerkracht);
            Assert.Equal(voornaam, leerkracht.Voornaam);
            Assert.Equal(familieNaam, leerkracht.FamilieNaam);
            Assert.Equal(adres, leerkracht.Adres);
            Assert.Equal(email, leerkracht.Email);
            Assert.Equal(rijksregisterNummer, leerkracht.RijksregisterNummer);
            Assert.Equal(geboorteDatum, leerkracht.GeboorteDatum);
            Assert.Equal(vakken, leerkracht.Vakken);
            Assert.Equal(werknemerType, leerkracht.WerknemerType);
        }
        [Fact]
        public void Leerkracht_NullVakken_ThrowsLeerkrachtException()
        {
            // Arrange
            var voornaam = "John";
            var familieNaam = "Doe";
            var adres = "Kerkstraat 1";
            var email = "john.doe@example.com";
            var rijksregisterNummer = "12345678923";
            var geboorteDatum = new DateTime(1999, 01, 01);
            List<string> vakken = null;
            var werknemerType = WerknemerType.Fulltime;

            // Act & Assert
            Assert.Throws<LeerkrachtException>(() => new Leerkracht(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum, vakken, werknemerType));            
        }
        [Theory]
        [InlineData(WerknemerType.Fulltime)]
        [InlineData(WerknemerType.Parttime)]
        public void Leerkracht_WerknemerType_Valid(WerknemerType werknemerType)
        {
            // Arrange
            string voornaam = "John";
            string familieNaam = "Doe";
            string adres = "Voorbeeldstraat 1";
            string email = "john.doe@example.com";
            string rijksregisterNummer = "12345678923";
            DateTime geboorteDatum = new DateTime(1998, 12, 1);
            List<string> vakken = new List<string>() { "Wiskunde", "Natuurkunde" };

            // Act
            Leerkracht leerkracht = new Leerkracht(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum, vakken, werknemerType);

            // Assert
            Assert.Equal(werknemerType, leerkracht.WerknemerType);
        }
        



    }
}
