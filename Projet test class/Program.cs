// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace bibliotheque
{
    public class Livres
    {
        string Titre;
        string Auteur;
        int AnneePub;
        int IDlivre;
        
        public Livres(string titre, string auteur, int anneepub, int idlivre)
        {
            Titre = titre;
            Auteur = auteur;
            AnneePub = anneepub;
            IDlivre = idlivre;
        }
        public override string ToString()
        {
            return $"{Titre} - {Auteur} (Année: {AnneePub}) (ID: {IDlivre})";
        }
    };
    public class Utilisateur
    {
        string Nom;
        string Prenom;
        int IDutilisateur;

        public Utilisateur(string nom, string prenom, int idutilisateur)
        {
            Nom = nom;
            Prenom = prenom;
            IDutilisateur = idutilisateur;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} {IDutilisateur}";
        }
    };

    public class Emprunts
    {

    };
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("Séléctionner une option :");
                Console.WriteLine("1. Afficher les livres disponibles");
                Console.WriteLine("2. Afficher les utilisateurs");
                Console.WriteLine("3. Afficher les emprunts en cours");
                Console.WriteLine("4. Quitter");
                string choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        Console.WriteLine("Listes des livres disponibles :");
                        break;

                    case "2":
                        Console.WriteLine("Listes des utilisateurs disponibles :");
                        break;

                    case "3":
                        Console.WriteLine("Listes des livres empruntés :");
                        break;

                    case "4":
                        Console.WriteLine("C'est chiao");
                        return;
                }
            }
        }
    }
}

