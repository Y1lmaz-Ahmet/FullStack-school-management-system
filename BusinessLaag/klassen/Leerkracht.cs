using BusinessLaag.Enums;
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
       public WerknemerType WerknemerType { get; private set; }
        #endregion
        #region Constructor
        public Leerkracht(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,DateTime geboorteDatum,List<string> vakken,WerknemerType werknemerType)
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum,"Leerkracht")
        {
            Vakken = vakken;
            WerknemerType = werknemerType;
        }
        #endregion
    }
}
