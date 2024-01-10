using System;

namespace Exercice07Figure.Classes
{
    internal class Carre : Figure
    {
        public double Cote { get; set; }

        public Carre(double cote, double x = 0, double y = 0) : base(x, y)
        {
            Cote = cote;
        }

        public override string ToString()
        {
            return $"Coordonnées du carré (Côté = {Cote}) :\n" +
                   $"A {Origine}\n" +
                   $"B {new Point(Origine.PosX + Cote, Origine.PosY)}\n" +
                   $"C {new Point(Origine.PosX + Cote, Origine.PosY - Cote)}\n" +
                   $"D {new Point(Origine.PosX, Origine.PosY - Cote)}";
        }
    }
}
