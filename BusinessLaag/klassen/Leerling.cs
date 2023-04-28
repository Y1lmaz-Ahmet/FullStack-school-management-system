using BusinessLaag.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public class Leerling : Personeel
    {

        #region Properties
        public int LeerJaar { get;private set; }
        public string KlasLokaal { get;private set; }
        #endregion

        #region Constructor
        public Leerling(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,DateTime geboorteDatum,int leerJaar,string klasLokaal)
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer,geboorteDatum,"Leerling")
        {
            try
            {
                if (leerJaar <= 0) throw new LeerlingException("Leerjaar kan niet 0 zijn.");
                LeerJaar = leerJaar;
                if (string.IsNullOrWhiteSpace(klasLokaal)) throw new LeerlingException("Klaslokaal mag niet leeg zijn.");
                KlasLokaal = klasLokaal;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

        }

       


        #endregion

        #region Methods

        #endregion
    }
}
