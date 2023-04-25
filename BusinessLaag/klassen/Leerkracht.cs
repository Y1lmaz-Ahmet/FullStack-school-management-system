using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public class Leerkracht : Personeel
    {
        #region Properties
        public  List<string> Vakken = new List<string>();
        #endregion
        #region Constructor
        public Leerkracht(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,List<string> vakken)
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer, "Leerkracht")
        {
            Vakken = vakken;
        }
        #endregion
    }
}
