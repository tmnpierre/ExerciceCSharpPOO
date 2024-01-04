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

        public Chaise(int nbDePied, string materiaux, string couleur)
        {
            _nbDePied = nbDePied;
            _materiaux = materiaux;
            _couleur = couleur;
        }

        public override string ToString()
        {
            return $"La chaise a {_nbDePied} pieds, est de couleur {_couleur} et est en {_materiaux}.";
        }
    }
}