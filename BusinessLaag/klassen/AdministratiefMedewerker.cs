﻿using BusinessLaag.Enums;
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
                throw new AdministratiefMedewerkerException("Er is een fout opgetreden bij het aanmaken van een Administratief medewerker.", ex);
            }
            
        }
        #endregion

        #region Methods

        #endregion
    }
}
