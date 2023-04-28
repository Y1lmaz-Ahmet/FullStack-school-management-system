using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLaag.klassen
{
    public interface IDataBeheer
    {
        void VoegStudentToe(Leerling leerling);
        void VerwijderStudent(string rijksregisterNummer);
        Leerling ZoekLeerlingOpRijksregisterNummer(string rijksregisterNummer);
        void UpdateLeerling(string rijksregisterNummer, Leerling leerling);
        List<Leerling> haalLeerlingen();
    }
}
