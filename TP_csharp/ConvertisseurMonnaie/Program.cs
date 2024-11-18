using System;
using System.Collections.Generic;

namespace ConvertisseurDevises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Convertisseur de devises ===");
            Console.WriteLine();

            // Taux de conversion
            var tauxDevises = new Dictionary<string, double>
            {
                { "Dollars US", 1.24 },
                { "Livres Sterling", 0.79 },
                { "Yen", 146.04 },
                { "Pesos mexicains", 17.04 },
                { "Francs CFA", 655.62 },
                { "Dinars algériens", 106.81 },
                { "Roubles russes", 58.22 },
                { "Yuan", 7.64 },
                { "Roupies indiens", 77.04 },
                { "Reals brésiliens", 3.16 }
            };

            // Choix du sens de conversion
            Console.WriteLine("Choisissez le sens de conversion :");
            Console.WriteLine("1. Euros -> Autre monnaie");
            Console.WriteLine("2. Autre monnaie -> Euros");
            Console.Write("Votre choix (1 ou 2) : ");
            string choixSens = Console.ReadLine();

            if (choixSens != "1" && choixSens != "2")
            {
                Console.WriteLine("Choix invalide. Programme terminé.");
                return;
            }

            // Afficher les devises disponibles
            Console.WriteLine();
            Console.WriteLine("Devises disponibles :");
            foreach (var devise in tauxDevises.Keys)
            {
                Console.WriteLine($"- {devise}");
            }

            // Choix de la devise
            Console.Write("Entrez le nom de la devise : ");
            string deviseChoisie = Console.ReadLine();

            if (!tauxDevises.ContainsKey(deviseChoisie))
            {
                Console.WriteLine("Devise invalide. Programme terminé.");
                return;
            }

            // Entrer le montant
            Console.Write("Entrez le montant : ");
            if (!double.TryParse(Console.ReadLine(), out double montant))
            {
                Console.WriteLine("Montant invalide. Programme terminé.");
                return;
            }

            // Conversion
            double taux = tauxDevises[deviseChoisie];
            double resultat;

            if (choixSens == "1")
            {
                resultat = montant * taux;
                Console.WriteLine($"{montant} Euros équivalent à {resultat:F2} {deviseChoisie}");
            }
            else
            {
                resultat = montant / taux;
                Console.WriteLine($"{montant} {deviseChoisie} équivalent à {resultat:F2} Euros");
            }

            // Fin du programme
            Console.WriteLine("Merci d'avoir utilisé le convertisseur de devises !");
        }
    }
}



