using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public class Personeel : Mens
    {
        #region Properties
        public string Functie { get;private set; }
        #endregion

        #region Constructor
        public Personeel(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,string functie) 
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer)
        {
            Functie = functie;
        }
        #endregion
    }
}
