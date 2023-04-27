using BusinessLaag.Enums;
using BusinessLaag.klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesten
{
    public class UnitAdministratiefMedewerker
    {
        [Fact]
        public void aanmakenAdministratiefMedewerker()
        {
            string voornaam = "John";
            string familieNaam = "Doe";
            string adres = "Voorbeeldstraat 1";
            string email = "john.doe@example.com";
            string rijksregisterNummer = "12345678923";
            DateTime geboorteDatum = new DateTime(1998, 12, 1);
            
            AdministratiefMedewerker admin = new AdministratiefMedewerker(voornaam,familieNaam,adres,
                email,rijksregisterNummer,geboorteDatum,WerknemerType.Parttime);
            Assert.IsType<AdministratiefMedewerker>(admin);
            Assert.NotNull(admin);
            Assert.Equal(voornaam,admin.Voornaam);
            Assert.Equal(familieNaam,admin.FamilieNaam);
            Assert.Equal(admin.Adres,admin.Adres);  
            Assert.Equal(email,admin.Email);
            Assert.Equal(rijksregisterNummer,admin.RijksregisterNummer);
            Assert.Equal(geboorteDatum,admin.GeboorteDatum);


        }
    }
}
