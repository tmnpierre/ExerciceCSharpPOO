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

        public override void Deplacement(double dx, double dy)
        {
            base.Deplacement(dx, dy);
        }

        public override string ToString()
        {
            return $"Coordonnée du Carré ABCD (Coté = 2) :\n" +
                $"Point A : {origine.PosX};{origine.PosY}\n" +
                $"Point B : {origine.PosX + 2};{origine.PosY}\n" +
                $"Point C : {origine.PosX + 2};{origine.PosY - 2}\n" +
                $"Point D : {origine.PosX};{origine.PosY - 2}\n" +
                $"___________________";
        }

    }
}