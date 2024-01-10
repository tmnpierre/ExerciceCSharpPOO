using System;

namespace Exercice07Figure.Classes
{
    internal class Rectangle : Figure
    {
        public double Longueur { get; set; }
        public double Largeur { get; set; }

        public Rectangle(double longueur, double largeur, double x = 0, double y = 0) : base(x, y)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public override string ToString()
        {
            return $"Coordonnées du rectangle (Longueur = {Longueur}, Largeur = {Largeur}) :\n" +
                   $"A {Origine}\n" +
                   $"B {new Point(Origine.PosX + Longueur, Origine.PosY)}\n" +
                   $"C {new Point(Origine.PosX + Longueur, Origine.PosY - Largeur)}\n" +
                   $"D {new Point(Origine.PosX, Origine.PosY - Largeur)}";
        }
    }
}
