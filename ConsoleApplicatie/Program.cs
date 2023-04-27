using BusinessLaag.Enums;
using BusinessLaag.klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int consoleWidth = Console.WindowWidth;
            string line = new string('*', consoleWidth);
            Console.WriteLine(line);
            List<string> Vakken = new List<string>() { "Wiskunde", "Nederlands", "Engels", "Aardrijkskunde", "Lichamelijke Opvoeding" };
            
            // Maak een leerling aan
            Leerling leerling = new Leerling("Jan", "Janssen", "Steenweg 1", "jan.janssen@test.be", "12345678923", new DateTime(1999, 12, 07), 1, "1A");

            Console.WriteLine($"{leerling.Functie}: {leerling.Voornaam} {leerling.FamilieNaam}");
            Console.WriteLine($"Adres: {leerling.Adres}");
            Console.WriteLine($"Email: {leerling.Email}");
            Console.WriteLine($"Rijksregisternummer: {leerling.RijksregisterNummer}");
            Console.WriteLine($"Geboortedatum: {leerling.GeboorteDatum.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Leerjaar: {leerling.LeerJaar}");
            Console.WriteLine($"Klaslokaal: {leerling.KlasLokaal}");
            Console.WriteLine(line);
            // Maak een leerkracht aan
            Leerkracht leerkracht = new Leerkracht("Piet", "Pieters", "Marktstraat 2", "piet.pieters@test.be", "02020200202", new DateTime(1978, 12, 06), Vakken, WerknemerType.Fulltime);

            Console.WriteLine($"{leerkracht.Functie}: {leerkracht.Voornaam} {leerkracht.FamilieNaam}");
            Console.WriteLine($"Adres: {leerkracht.Adres}");
            Console.WriteLine($"Email: {leerkracht.Email}");
            Console.WriteLine($"Rijksregisternummer: {leerkracht.RijksregisterNummer}");
            Console.WriteLine($"Geboortedatum: {leerkracht.GeboorteDatum.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Vakken: {string.Join(", ", leerkracht.Vakken)}");
            Console.WriteLine($"Werknemer type: {leerkracht.WerknemerType}");
            Console.WriteLine(line);

            // Maak een administratief medewerker
            AdministratiefMedewerker admin = new AdministratiefMedewerker("femke", "Den Bosch", "FemkeStraat 16 w2", "Femke@admin.com", "12345678912", new DateTime(1980, 6, 7), WerknemerType.Parttime);

            Console.WriteLine($"{admin.Functie}: {admin.Voornaam} {admin.FamilieNaam}");
            Console.WriteLine($"Adres: {admin.Adres}");
            Console.WriteLine($"Email: {admin.Email}");
            Console.WriteLine($"Rijksregisternummer: {admin.RijksregisterNummer}");
            Console.WriteLine($"Geboortedatum: {admin.GeboorteDatum.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Werknemer type: {admin.WerknemerType}");
            Console.WriteLine(line);

            //admin.VoegStudentToe(leerling);
            Leerling leerling1 = new Leerling("Emma", "De Boer", "Dorpstraat 1", "emma.deboer@test.be", "12345678902", new DateTime(2005, 2, 15),1,"A");
            Leerling leerling2 = new Leerling("Finn", "Janssens", "Dorpsstraat 2", "finn.janssens@test.be", "12345678903", new DateTime(2006, 3, 20), 2, "B");
            admin.VoegStudentToe(leerling1);
            admin.VoegStudentToe(leerling2);
            foreach (Leerling l in admin.haalLeerlingen())
            {
                Console.WriteLine("----LEERLING-----");
                Console.WriteLine($"{l.Functie}: {l.Voornaam} {l.FamilieNaam}");
                Console.WriteLine($"Adres: {l.Adres}");
                Console.WriteLine($"Email: {l.Email}");
                Console.WriteLine($"Rijksregisternummer: {l.RijksregisterNummer}");
                Console.WriteLine($"Geboortedatum: {l.GeboorteDatum.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"leerjaar: {l.LeerJaar}");
                Console.WriteLine($"klas: {l.KlasLokaal}");
                Console.WriteLine("----LEERLING-----");
            }
            Console.WriteLine("zoekopnummer");
            Console.WriteLine( admin.ZoekLeerlingOpRijksregisterNummer("12345678903"));

            //testen voor updaten leerling:
            Leerling thomas = new Leerling("Thomas", "Van Broeken", "Dorpstraat 1", "thomas.van.broeken@test.be", "15975385264", new DateTime(2005, 2, 15), 1, "A");
            admin.VoegStudentToe(thomas);

            // toon de leerling voor de update
            Console.WriteLine("Voor de update:");
            Leerling oudeLeerling = admin.ZoekLeerlingOpRijksregisterNummer("15975385264");
            Console.WriteLine($"Naam: {oudeLeerling.Voornaam} {oudeLeerling.FamilieNaam}, Adres: {oudeLeerling.Adres}");

            // update de leerling
            Leerling nieuweLeerling = new Leerling("Thomas", "Van den Broeck", "Kerkstraat 10", "thomas.van.broeck@test.be", "15975385264", new DateTime(2005, 2, 15), 1, "A");
            admin.UpdateLeerling("15975385264", nieuweLeerling);

            // toon de leerling na de update
            Console.WriteLine("Na de update:");
            Leerling geupdateteLeerling = admin.ZoekLeerlingOpRijksregisterNummer("15975385264");
            Console.WriteLine($"Naam: {geupdateteLeerling.Voornaam} {geupdateteLeerling.FamilieNaam}, Adres: {geupdateteLeerling.Adres}");
            //Zodat de console niet sluit.
            Console.ReadLine();
        }
    }
}
