using BusinessLaag.Enums;
using BusinessLaag.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public class AdministratiefMedewerker : Personeel
    {
        #region Properties
        public WerknemerType  WerknemerType { get;private set; }
        private Dictionary<string,Leerling> leerlingen = new Dictionary<string,Leerling>();
        #endregion

        #region Constructor
        public AdministratiefMedewerker(string voornaam, string familieNaam, string adres, string email,string rijksregisterNummer,
            DateTime geboorteDatum,WerknemerType werknemerType)
            : base(voornaam, familieNaam, adres, email, rijksregisterNummer, geboorteDatum,"Administratief medewerker")
        {
            try
            {
                if (!Enum.IsDefined(typeof(WerknemerType), werknemerType)) throw new AdministratiefMedewerkerException("WerknemerType moet gekozen worden.");
                WerknemerType = werknemerType;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        #endregion

        #region Methods
        public void VoegStudentToe(Leerling leerling)
        {
            if (leerling == null) throw new AdministratiefMedewerkerException("er kon geen leerling gevonden worden.");
            if(leerlingen.ContainsKey(leerling.RijksregisterNummer))
            {
                throw new AdministratiefMedewerkerException("sorry,deze student zit al in onze databank.");
            }else
            {
                leerlingen.Add(leerling.RijksregisterNummer,leerling);
            }
            
        }
        public void VerwijderStudent(string rijksregisterNummer)
        {
            if (rijksregisterNummer == null) throw new AdministratiefMedewerkerException("[VerwijderStudent]:rijksregisterNummer is leeg of fout.");
            leerlingen.Remove(rijksregisterNummer);
        }
        public Leerling ZoekLeerlingOpRijksregisterNummer(string rijksregisterNummer)
        {
            if (rijksregisterNummer == null) throw new AdministratiefMedewerkerException("rijksregisternummer is fout.");
            if (leerlingen.ContainsKey(rijksregisterNummer)) return leerlingen[rijksregisterNummer];
            return null;
           
        }
        public void UpdateLeerling(string rijksregisterNummer,Leerling leerling)
        {
            if (!leerlingen.ContainsKey(rijksregisterNummer))
            {
                throw new AdministratiefMedewerkerException("sorry, leerling met de gegeven rijksregisternummer kon niet gevonden worden.");
            }else
            {
                leerlingen[rijksregisterNummer] = leerling;
            }

        }
        public List<Leerling> haalLeerlingen()
        {
            return new List<Leerling>(leerlingen.Values);
        }
        #endregion
    }
}
