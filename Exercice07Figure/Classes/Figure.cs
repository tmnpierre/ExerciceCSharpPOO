using Exercice07Figure.Interfaces;

namespace Exercice07Figure.Classes
{
    internal abstract class Figure : IDeplacable
    {
        public Point Origine { get; set; }

        protected Figure(double x, double y)
        {
            Origine = new Point(x, y);
        }

        public virtual void Deplacement(double dx, double dy)
        {
            Origine.PosX += dx;
            Origine.PosY += dy;
        }

        public override string ToString()
        {
            return $"Figure à l'origine {Origine}";
        }
    }
}
