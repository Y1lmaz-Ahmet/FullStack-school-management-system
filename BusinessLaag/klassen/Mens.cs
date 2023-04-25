using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public class Mens
    {
        #region Properties
        public string Voornaam { get;private set; }
        public string FamilieNaam { get; private set; }
        public string Adres { get;private set; }
        public string Email { get; set; }
        public int RijksregisterNummer { get;private set; }
        #endregion

        #region Constructor
        public Mens(string voornaam, string familieNaam, string adres, string email, int rijksregisterNummer)
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
            return $"{this.GetType()},{Voornaam},{FamilieNaam},{Adres},{Email},{RijksregisterNummer}";
        }
        #endregion
    }
}
