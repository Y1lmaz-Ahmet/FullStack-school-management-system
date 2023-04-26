using BusinessLaag.Enums;
using BusinessLaag.exceptions;
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
        public Personeel(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,DateTime geboorteDatum,string functie) 
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer,geboorteDatum)
        {
            if (string.IsNullOrWhiteSpace(functie)) throw new PersoneelException("functie moet ingevuld worden.");
            Functie = functie;
        }
        #endregion
    }
}
