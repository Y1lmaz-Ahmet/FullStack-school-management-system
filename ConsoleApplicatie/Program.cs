using BusinessLaag.Enums;
using BusinessLaag.klassen;
using DataLaag;
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
            //int consoleWidth = Console.WindowWidth;
            //string line = new string('*', consoleWidth);
            //Console.WriteLine(line);
            //List<string> Vakken = new List<string>() { "Wiskunde", "Nederlands", "Engels", "Aardrijkskunde", "Lichamelijke Opvoeding" };
            
            //// Maak een leerling aan
            //Leerling leerling = new Leerling("Jan", "Janssen", "Steenweg 1", "jan.janssen@test.be", "12345678923", new DateTime(1999, 12, 07), 1, "1A");

            //Console.WriteLine($"{leerling.Functie}: {leerling.Voornaam} {leerling.FamilieNaam}");
            //Console.WriteLine($"Adres: {leerling.Adres}");
            //Console.WriteLine($"Email: {leerling.Email}");
            //Console.WriteLine($"Rijksregisternummer: {leerling.RijksregisterNummer}");
            //Console.WriteLine($"Geboortedatum: {leerling.GeboorteDatum.ToString("dd/MM/yyyy")}");
            //Console.WriteLine($"Leerjaar: {leerling.LeerJaar}");
            //Console.WriteLine($"Klaslokaal: {leerling.KlasLokaal}");
            //Console.WriteLine(line);
            //// Maak een leerkracht aan
            //Leerkracht leerkracht = new Leerkracht("Piet", "Pieters", "Marktstraat 2", "piet.pieters@test.be", "02020200202", new DateTime(1978, 12, 06), Vakken, WerknemerType.Fulltime);

            //Console.WriteLine($"{leerkracht.Functie}: {leerkracht.Voornaam} {leerkracht.FamilieNaam}");
            //Console.WriteLine($"Adres: {leerkracht.Adres}");
            //Console.WriteLine($"Email: {leerkracht.Email}");
            //Console.WriteLine($"Rijksregisternummer: {leerkracht.RijksregisterNummer}");
            //Console.WriteLine($"Geboortedatum: {leerkracht.GeboorteDatum.ToString("dd/MM/yyyy")}");
            //Console.WriteLine($"Vakken: {string.Join(", ", leerkracht.Vakken)}");
            //Console.WriteLine($"Werknemer type: {leerkracht.WerknemerType}");
            //Console.WriteLine(line);

            //// Maak een administratief medewerker
            //AdministratiefMedewerker admin = new AdministratiefMedewerker("femke", "Den Bosch", "FemkeStraat 16 w2", "Femke@admin.com", "12345678912", new DateTime(1980, 6, 7), WerknemerType.Parttime);

            //Console.WriteLine($"{admin.Functie}: {admin.Voornaam} {admin.FamilieNaam}");
            //Console.WriteLine($"Adres: {admin.Adres}");
            //Console.WriteLine($"Email: {admin.Email}");
            //Console.WriteLine($"Rijksregisternummer: {admin.RijksregisterNummer}");
            //Console.WriteLine($"Geboortedatum: {admin.GeboorteDatum.ToString("dd/MM/yyyy")}");
            //Console.WriteLine($"Werknemer type: {admin.WerknemerType}");
            //Console.WriteLine(line);

            ////admin.VoegStudentToe(leerling);
            //Leerling leerling1 = new Leerling("Emma", "De Boer", "Dorpstraat 1", "emma.deboer@test.be", "12345678902", new DateTime(2005, 2, 15),1,"A");
            //Leerling leerling2 = new Leerling("Finn", "Janssens", "Dorpsstraat 2", "finn.janssens@test.be", "12345678903", new DateTime(2006, 3, 20), 2, "B");
            //admin.VoegStudentToe(leerling1);
            //admin.VoegStudentToe(leerling2);
            //foreach (Leerling l in admin.haalLeerlingen())
            //{
            //    Console.WriteLine("----LEERLING-----");
            //    Console.WriteLine($"{l.Functie}: {l.Voornaam} {l.FamilieNaam}");
            //    Console.WriteLine($"Adres: {l.Adres}");
            //    Console.WriteLine($"Email: {l.Email}");
            //    Console.WriteLine($"Rijksregisternummer: {l.RijksregisterNummer}");
            //    Console.WriteLine($"Geboortedatum: {l.GeboorteDatum.ToString("dd/MM/yyyy")}");
            //    Console.WriteLine($"leerjaar: {l.LeerJaar}");
            //    Console.WriteLine($"klas: {l.KlasLokaal}");
            //    Console.WriteLine("----LEERLING-----");
            //}
            //Console.WriteLine("zoekopnummer");
            //Console.WriteLine( admin.ZoekLeerlingOpRijksregisterNummer("12345678903"));

            ////testen voor updaten leerling:
            //Leerling thomas = new Leerling("Thomas", "Van Broeken", "Dorpstraat 1", "thomas.van.broeken@test.be", "15975385264", new DateTime(2005, 2, 15), 1, "A");
            //admin.VoegStudentToe(thomas);

            //// toon de leerling voor de update
            //Console.WriteLine("Voor de update:");
            //Leerling oudeLeerling = admin.ZoekLeerlingOpRijksregisterNummer("15975385264");
            //Console.WriteLine($"Naam: {oudeLeerling.Voornaam} {oudeLeerling.FamilieNaam}, Adres: {oudeLeerling.Adres}");

            //// update de leerling
            //Leerling nieuweLeerling = new Leerling("Thomas", "Van den Broeck", "Kerkstraat 10", "thomas.van.broeck@test.be", "15975385264", new DateTime(2005, 2, 15), 1, "A");
            //admin.UpdateLeerling("15975385264", nieuweLeerling);

            //// toon de leerling na de update
            //Console.WriteLine("Na de update:");
            //Leerling geupdateteLeerling = admin.ZoekLeerlingOpRijksregisterNummer("15975385264");
            //Console.WriteLine($"Naam: {geupdateteLeerling.Voornaam} {geupdateteLeerling.FamilieNaam}, Adres: {geupdateteLeerling.Adres}");
            ////Zodat de console niet sluit.
            //admin.VerwijderStudent("15975385264");
            //admin.VoegStudentToe(nieuweLeerling);
            //foreach (Leerling l in admin.haalLeerlingen())
            //{
            //    Console.WriteLine("----LEERLING-----");
            //    Console.WriteLine($"{l.Functie}: {l.Voornaam} {l.FamilieNaam}");
            //    Console.WriteLine($"Adres: {l.Adres}");
            //    Console.WriteLine($"Email: {l.Email}");
            //    Console.WriteLine($"Rijksregisternummer: {l.RijksregisterNummer}");
            //    Console.WriteLine($"Geboortedatum: {l.GeboorteDatum.ToString("dd/MM/yyyy")}");
            //    Console.WriteLine($"leerjaar: {l.LeerJaar}");
            //    Console.WriteLine($"klas: {l.KlasLokaal}");
            //    Console.WriteLine("----LEERLING-----");
            //}

            Databeheer databeheer = new Databeheer("Data Source=DESKTOP-698J12G;Initial Catalog=schoolDatabank;Integrated Security=True");
            //databeheer.VoegStudentToe(leerling1);
            //databeheer.VerwijderStudent("12345678902");
            //--- AANMAKEN NIEUWE STUDENT EN TOEVOEGEN IN DATABANK ---
            //Leerling leerling2 = new Leerling("Liam", "Van Damme", "Parklaan 10", "liam.vandamme@test.be", "23456789013", new DateTime(2004, 3, 22), 1, "A");
            //Leerling leerling3 = new Leerling("Nora", "Vermeulen", "Kerkstraat 12", "nora.vermeulen@test.be", "34567890124", new DateTime(2005, 8, 11), 1, "B");
            //Leerling leerling4 = new Leerling("Finn", "Van Hove", "Koningin Astridlaan 23", "finn.vanhove@test.be", "45678901235", new DateTime(2004, 5, 8), 2, "A");
            //Leerling leerling5 = new Leerling("Julie", "Vandenberghe", "Nieuwstraat 45", "julie.vandenberghe@test.be", "56789012346", new DateTime(2005, 6, 14), 2, "B");
            //Leerling leerling6 = new Leerling("Daan", "Verstraete", "Kerkhofstraat 8", "daan.verstraete@test.be", "67890123457", new DateTime(2004, 11, 9), 3, "A");
            //Leerling leerling7 = new Leerling("Ella", "Jacobs", "Ooststraat 17", "ella.jacobs@test.be", "78901234568", new DateTime(2005, 10, 3), 3, "B");
            //Leerling leerling8 = new Leerling("Lars", "De Smet", "Stationsstraat 2", "lars.desmet@test.be", "89012345679", new DateTime(2004, 12, 31), 4, "A");
            //Leerling leerling9 = new Leerling("Tess", "Coppens", "Kasteelstraat 33", "tess.coppens@test.be", "90123456780", new DateTime(2005, 7, 27), 4, "B");
            //Leerling leerling10 = new Leerling("Seppe", "Lemmens", "Marktplein 14", "seppe.lemmens@test.be", "01234567891", new DateTime(2004, 9, 18), 5, "A");
            //Leerling leerling11 = new Leerling("Laura", "Willems", "Oude Baan 26", "laura.willems@test.be", "12345678902", new DateTime(2005, 4, 5), 5, "B");
            //Leerling leerling12 = new Leerling("Mathis", "Peeters", "Gentsesteenweg 9", "mathis.peeters@test.be", "23456789013", new DateTime(2004, 2, 28), 6, "A");
            //Leerling leerling13 = new Leerling("Lotte", "Maes", "Brusselsestraat 7", "lotte.maes@test.be", "34567890124", new DateTime(2005, 1, 13), 6, "B");
            //databeheer.VoegStudentToe(leerling2);
            //databeheer.VoegStudentToe(leerling3);
            //databeheer.VoegStudentToe(leerling4);
            //databeheer.VoegStudentToe(leerling5);
            //databeheer.VoegStudentToe(leerling6);
            //databeheer.VoegStudentToe(leerling7);
            //databeheer.VoegStudentToe(leerling8);
            //databeheer.VoegStudentToe(leerling9);
            //databeheer.VoegStudentToe(leerling10);
            //databeheer.VoegStudentToe(leerling11);
            //databeheer.VoegStudentToe(leerling12);
            //databeheer.VoegStudentToe(leerling13);
            //--- AANMAKEN NIEUWE STUDENT EN TOEVOEGEN IN DATABANK ---

            //--- VERWIJDEREN VAN STUDENT DOOR RIJKSREGISTERNUMMER MEE TE GEVEN ---
            //databeheer.VerwijderStudent("78901234568");
            //--- VERWIJDEREN VAN STUDENT DOOR RIJKSREGISTERNUMMER MEE TE GEVEN ---


            //--- UPDATEN VAN STUDENT DOOR RIJKSREGISTERNUMMER MEE TE GEVEN ALS SEARCH DAN DE UPDATED VERSIE VAN DE STUDENT ---
            //Leerling UpdatedLeerling6 = new Leerling("trolly", "TrollyStraat 99f5", "Kerkhofstraat 8", "daan.verstraete@test.be", "67890123457", new DateTime(2004, 11, 9), 4, "C");
            //databeheer.UpdateLeerling("67890123457", UpdatedLeerling6);
            //--- UPDATEN VAN STUDENT DOOR RIJKSREGISTERNUMMER MEE TE GEVEN ALS SEARCH DAN DE UPDATED VERSIE VAN DE STUDENT ---

            Console.ReadLine();
        }
    }
}
