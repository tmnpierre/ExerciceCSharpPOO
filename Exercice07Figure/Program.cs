using Exercice07Figure.Classes;
using System;

namespace Exercice07Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figureSelectionnee = null;
            bool continuer = true;

            while (continuer)
            {
                Console.Clear();
                Console.WriteLine("Gestion des Figures Géométriques");
                Console.WriteLine("1) Créer un nouveau Point");
                Console.WriteLine("2) Créer un nouveau Carré");
                Console.WriteLine("3) Créer un nouveau Rectangle");
                Console.WriteLine("4) Créer un nouveau Triangle");
                Console.WriteLine("5) Déplacer une Figure");
                Console.WriteLine("6) Afficher la Figure");
                Console.WriteLine("7) Quitter");
                Console.Write("\nSélectionnez une option : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        figureSelectionnee = CreerPoint();
                        break;
                    case "2":
                        figureSelectionnee = CreerCarre();
                        break;
                    case "3":
                        figureSelectionnee = CreerRectangle();
                        break;
                    case "4":
                        figureSelectionnee = CreerTriangle();
                        break;
                    case "5":
                        if (figureSelectionnee != null)
                        {
                            DeplacerFigure(figureSelectionnee);
                        }
                        else
                        {
                            Console.WriteLine("Aucune figure sélectionnée pour le déplacement.");
                        }
                        break;
                    case "6":
                        if (figureSelectionnee != null)
                        {
                            Console.WriteLine(figureSelectionnee);
                        }
                        else
                        {
                            Console.WriteLine("Aucune figure sélectionnée pour l'affichage.");
                        }
                        break;
                    case "7":
                        continuer = false;
                        break;
                    default:
                        Console.WriteLine("Option invalide.");
                        break;
                }

                if (continuer)
                {
                    Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                    Console.ReadKey();
                }
            }
        }


    }
}
