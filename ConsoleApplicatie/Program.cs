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
            List<string> Vakken = new List<string>() {"Wiskune","Nederlands","Engels","Aardrijkskunde","LichaamlijkeOpvoeding" };
            // Maak een leerling aan
            Leerling leerling = new Leerling("Jan", "Janssen", "Steenweg 1", "jan.janssen@test.be", "01010100101",new DateTime(1999,12,07), 1, "1A");

            //// Maak een leerkracht aan
            //Leerkracht leerkracht = new Leerkracht("Piet", "Pieters", "Marktstraat 2", "piet.pieters@test.be", "02.02.02-002.02", new DateTime(1978, 12, 06), Vakken,WerknemerType.Fulltime);

            //// Toon de gegevens van de leerling
            Console.WriteLine($"{leerling.Functie}: {leerling.Voornaam} is ingeschreven in leerjaar {leerling.LeerJaar} en zit in klaslokaal {leerling.KlasLokaal}.");

            //// Toon de gegevens van de leerkracht
            //Console.WriteLine($"{leerkracht.Functie}: {leerkracht.Voornaam} geeft het vak {string.Join(", ",Vakken)}.");

            //Console.WriteLine($"{leerkracht.Functie}: {leerkracht.Voornaam} is geboren op:{leerkracht.GeboorteDatum}\n en hij werkt {leerkracht.WerknemerType}");
            //Console.WriteLine($"{leerling.Functie}: {leerling.Voornaam} is geboren op:{leerling.GeboorteDatum}");

            Console.ReadLine();
        }
    }
}
