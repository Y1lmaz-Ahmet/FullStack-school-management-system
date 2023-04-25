﻿using BusinessLaag.klassen;
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
            Leerling leerling = new Leerling("Jan", "Janssen", "Steenweg 1", "jan.janssen@test.be", "01.01.01-001.01", 1, "1A");

            // Maak een leerkracht aan
            Leerkracht leerkracht = new Leerkracht("Piet", "Pieters", "Marktstraat 2", "piet.pieters@test.be", "02.02.02-002.02",Vakken);

            // Toon de gegevens van de leerling
            Console.WriteLine($"{leerling.Functie}: {leerling.Voornaam} is ingeschreven in leerjaar {leerling.LeerJaar} en zit in klaslokaal {leerling.KlasLokaal}.");

            // Toon de gegevens van de leerkracht
            Console.WriteLine($"{leerkracht.Functie}: {leerkracht.Voornaam} geeft het vak {string.Join(", ",Vakken)}.");

            

            Console.ReadLine();
        }
    }
}
