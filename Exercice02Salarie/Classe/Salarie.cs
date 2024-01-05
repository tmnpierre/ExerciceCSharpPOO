namespace Exercice02Salarie.Classe
{
    internal class Salarie
    {
        private static int _nbSalarie = 0;
        private static double _totalSalaires = 0;

        public string Matricule { get; set; } = "0000";
        public string Service { get; set; } = "Service00";
        public string Nom { get; set; } = "Salarie par défaut";
        private double _salaire = 16236;

        public double Salaire
        {
            get { return _salaire; }
            set
            {
                _totalSalaires -= _salaire;
                _salaire = value;
                _totalSalaires += value;
            }
        }

        public static int NbSalarie => _nbSalarie;

        public Salarie()
        {
            _nbSalarie++;
        }

        public Salarie(string matricule, string service, string nom, double salaire) : this()
        {
            Matricule = matricule;
            Service = service;
            Nom = nom;
            Salaire = salaire;
        }

        public static double SumSalaires()
        {
            return _totalSalaires;
        }

        public static double MoyenneSalaires()
        {
            return _nbSalarie > 0 ? _totalSalaires / _nbSalarie : 0;
        }

        public static void ResetNbSalarie()
        {
            _nbSalarie = 0;
        }

        public static void ResetTotalSalaires()
        {
            _totalSalaires = 0;
        }
        public override string ToString()
        {
            return $"Le salaire de {Nom} est de {Salaire} euros. \n Matricule : {Matricule}, Service : {Service} \n";
        }
    }
}
