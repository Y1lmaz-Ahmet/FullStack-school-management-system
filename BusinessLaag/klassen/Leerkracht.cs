using BusinessLaag.Enums;
using BusinessLaag.exceptions;
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
            try
            {
                if (vakken.Count == 0 || vakken == null) throw new LeerkrachtException("Een leerkracht moet minstens 1 vak hebben.");
                Vakken = vakken;
                if (!Enum.IsDefined(typeof(WerknemerType), werknemerType)) throw new LeerkrachtException("Ongeldige waarde voor werknemerType.");
                WerknemerType = werknemerType;
            }
            catch (Exception ex)
            {
                throw new LeerkrachtException("Er is een fout opgetreden bij het aanmaken van een Leerkracht.", ex);
            }
        }
        #endregion
    }
}
