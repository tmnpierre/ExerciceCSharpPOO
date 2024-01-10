using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Point
    {
        public double PosX { get; set; } = 2;
        public double PosY { get; set; } = 4;

        public override string ToString()
        {
            return $"La position initial est {PosX};{PosY}";
        }
    }
}
