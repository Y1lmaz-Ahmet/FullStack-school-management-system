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
        #endregion

        #region Constructor
        public Mens(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer)
        {
            Voornaam = voornaam;
            FamilieNaam = familieNaam;
            Adres = adres;
            Email = email;
            RijksregisterNummer = rijksregisterNummer;
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
