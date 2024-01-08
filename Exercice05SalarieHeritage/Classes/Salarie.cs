namespace Exercice05SalarieHeritage.Classes
{
    public class Salarie
    {
        private decimal _salaire;

        public decimal Salaire
        {
            get => _salaire;
            set
            {
                TotalSalaires -= _salaire;
                _salaire = value;
                TotalSalaires += _salaire;
            }
        }

        public string Matricule { get; set; } = "000";
        public string Nom { get; set; } = "Salarié par défaut";
        public string Service { get; set; } = "Service par défaut";
        public string Categorie { get; set; } = "Catégorie par défaut";

        public static int NombreSalaries { get; private set; } = 0;
        public static decimal TotalSalaires { get; private set; } = 0;

        public static decimal MoyenneSalaires => TotalSalaires / NombreSalaries;

        public Salarie()
        {
            NombreSalaries++;
            Salaire = 16236;
        }

        public Salarie(string matricule, string nom, string service, string categorie, decimal salaire) : this()
        {
            Salaire = salaire;
            Matricule = matricule;
            Nom = nom;
            Service = service;
            Categorie = categorie;
        }

        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }

        public static void RemiseAZero()
        {
            NombreSalaries = 0;
            TotalSalaires = 0;
        }

        public override string ToString()
        {
            return $"Salarie: Matricule: {Matricule}, Nom: {Nom}, Service: {Service}, Catégorie: {Categorie}, Salaire: {Salaire}";
        }
    }
}