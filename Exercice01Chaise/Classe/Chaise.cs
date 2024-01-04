using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01Chaise.Classe
{
    internal class Chaise
    {
        private int _nbDePied;
        private string _materiaux;
        private string _couleur;
        public int NbDePied { get => _nbDePied; set => _nbDePied = value; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        public void Afficher()
        {
            Console.WriteLine($"La chaise à {_nbDePied}, et de couleur {_couleur} en {_materiaux}");
        }
        public Chaise(int NbDePied, string Materiaux, string Couleur)
        {
            _nbDePied = NbDePied;
            _materiaux= Materiaux;
            _couleur = Couleur;
        }
    }
}
