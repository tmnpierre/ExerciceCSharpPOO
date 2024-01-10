using System;

namespace Exercice07Figure.Classes
{
    internal class Point
    {
        public double PosX { get; set; }
        public double PosY { get; set; }

        public Point(double posX = 0, double posY = 0)
        {
            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
            return $"({PosX};{PosY})";
        }
    }
}
