using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Rectangle : Figure
    {
        public double Longueur {  get; set; }
        public double Largeur { get; set; }

        public override void Deplacement(double dx, double dy)
        {
            base.Deplacement(dx, dy);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
