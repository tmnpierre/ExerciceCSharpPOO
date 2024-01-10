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
                Console.WriteLine("1) Créer un nouveau Carré");
                Console.WriteLine("2) Créer un nouveau Rectangle");
                Console.WriteLine("3) Créer un nouveau Triangle");
                Console.WriteLine("4) Déplacer une Figure");
                Console.WriteLine("5) Afficher la Figure");
                Console.WriteLine("6) Quitter");
                Console.Write("\nSélectionnez une option : ");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        figureSelectionnee = CreerCarre();
                        break;
                    case "2":
                        figureSelectionnee = CreerRectangle();
                        break;
                    case "3":
                        figureSelectionnee = CreerTriangle();
                        break;
                    case "4":
                        if (figureSelectionnee != null)
                        {
                            DeplacerFigure(figureSelectionnee);
                        }
                        else
                        {
                            Console.WriteLine("Aucune figure sélectionnée pour le déplacement.");
                        }
                        break;
                    case "5":
                        if (figureSelectionnee != null)
                        {
                            Console.WriteLine(figureSelectionnee);
                        }
                        else
                        {
                            Console.WriteLine("Aucune figure sélectionnée pour l'affichage.");
                        }
                        break;
                    case "6":
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
        static Carre CreerCarre()
        {
            Console.Write("Entrez la longueur du côté du carré : ");
            double cote = Convert.ToDouble(Console.ReadLine());

            Carre carre = new Carre(cote);
            Console.WriteLine("Carré créé avec succès !");
            return carre;
        }

        static Rectangle CreerRectangle()
        {
            Console.Write("Entrez la longueur du rectangle : ");
            double longueur = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez la largeur du rectangle : ");
            double largeur = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(longueur, largeur);
            Console.WriteLine("Rectangle créé avec succès !");
            return rectangle;
        }

        static Triangle CreerTriangle()
        {
            Console.Write("Entrez la base du triangle : ");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez la hauteur du triangle : ");
            double hauteur = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle(baseTriangle, hauteur);
            Console.WriteLine("Triangle créé avec succès !");
            return triangle;
        }

        static void DeplacerFigure(Figure figure)
        {
            Console.Write("Entrez le déplacement sur l'axe X : ");
            double dx = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez le déplacement sur l'axe Y : ");
            double dy = Convert.ToDouble(Console.ReadLine());

            figure.Deplacement(dx, dy);
            Console.WriteLine("Figure déplacée avec succès !");
        }
    }
}
