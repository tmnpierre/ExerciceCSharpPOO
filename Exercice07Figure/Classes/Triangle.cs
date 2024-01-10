using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Triangle : Figure
    {
        public double Base {  get; set; }
        public double Hauteur { get; set; }

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
