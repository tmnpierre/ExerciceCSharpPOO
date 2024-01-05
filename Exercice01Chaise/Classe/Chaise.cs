namespace Exercice01Chaise.Classe
{
    internal class Chaise
    {
        public int NbDePied { get; set; }
        public string Materiaux { get; set; }
        public string Couleur { get; set; }

        public Chaise(int nbDePied, string materiaux, string couleur)
        {
            NbDePied = nbDePied;
            Materiaux = materiaux;
            Couleur = couleur;
        }

        public override string ToString()
        {
            return $"La chaise a {NbDePied} pieds, est de couleur {Couleur} et est en {Materiaux}.";
        }
    }
}
