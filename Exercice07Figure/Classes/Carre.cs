using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice07Figure.Interfaces;

namespace Exercice07Figure.Classes
{
    internal class Carre : Figure
    {
        public double Cote {  get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Deplacement(double dx, double dy)
        {
            base.Deplacement(dx, dy);
        }
    }
}