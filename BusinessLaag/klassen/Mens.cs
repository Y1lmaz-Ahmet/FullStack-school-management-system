using BusinessLaag.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public abstract class Mens
    {
        #region Properties
        public string Voornaam { get;private set; }
        public string FamilieNaam { get; private set; }
        public string Adres { get;private set; }
        public string Email { get;private set; }
        public string RijksregisterNummer { get;private set; }
        public DateTime GeboorteDatum { get;private set; }
        #endregion

        #region Constructor
        public Mens(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,DateTime geboorteDatum)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(voornaam)) throw new MensException("Naam mag niet leeg zijn.");
                Voornaam = voornaam;
                if (string.IsNullOrWhiteSpace(familieNaam)) throw new MensException("Familienaam mag niet leeg zijn.");
                FamilieNaam = familieNaam;
                if (string.IsNullOrWhiteSpace(adres)) throw new MensException("Adres mag niet leeg zijn.");
                Adres = adres;
                if (string.IsNullOrWhiteSpace(email)) throw new MensException("Email mag niet leeg zijn.");
                Email = email;
                if (string.IsNullOrWhiteSpace(rijksregisterNummer) || rijksregisterNummer.Length != 11)
                 throw new MensException("Een rijksregisternummer bestaat uit 11 waarden en mag niet leeg zijn.");
                RijksregisterNummer = rijksregisterNummer;
                if (geboorteDatum == null) throw new MensException("GeboorteDatum moet ingevuld worden. yyyy-mm-dd");   
                GeboorteDatum = geboorteDatum;
            }
            catch (Exception ex)
            {
                throw new MensException("Er is een fout opgetreden bij het aanmaken van een mens.", ex);
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Voornaam},{FamilieNaam},{Adres},{Email},{RijksregisterNummer}";
        }
        #endregion
    }
}
