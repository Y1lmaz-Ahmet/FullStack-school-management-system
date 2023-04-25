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
        public Leerling(string voornaam, string familieNaam, string adres, string email, string rijksregisterNummer,int leerJaar,string klasLokaal)
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer,"Leerling")
        {
            LeerJaar = leerJaar;
            KlasLokaal = klasLokaal;
        }
        #endregion

        #region Methods
        
        #endregion
    }
}
