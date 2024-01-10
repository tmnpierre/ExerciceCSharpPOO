using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice07Figure.Interfaces;

namespace Exercice07Figure.Classes
{
    internal abstract class Figure : IDeplacement 
    {
        public Point origine;

        public virtual void Deplacement(double dx, double dy)
        {
            origine.PosX += dx;
            origine.PosY += dy;
        }
    }
}