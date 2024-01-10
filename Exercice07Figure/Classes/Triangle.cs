using System;

namespace Exercice07Figure.Classes
{
    internal class Triangle : Figure
    {
        public double Base { get; set; }
        public double Hauteur { get; set; }

        public Triangle(double baseLength, double hauteur, double x = 0, double y = 0) : base(x, y)
        {
            Base = baseLength;
            Hauteur = hauteur;
        }

        public override string ToString()
        {
            return $"Coordonnées du triangle isocèle (Base = {Base}, Hauteur = {Hauteur}) :\n" +
                   $"A {Origine}\n" +
                   $"B {new Point(Origine.PosX + Base, Origine.PosY)}\n" +
                   $"C {new Point(Origine.PosX + Base / 2, Origine.PosY - Hauteur)}";
        }
    }
}
