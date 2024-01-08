namespace Exercice05SalarieHeritage.Classes;

public class Salarie
{

    // propfull => 1 attribut et sa propriété
    private decimal _salaire;

    public decimal Salaire
    {
        get => _salaire;
        set
        {
            TotalSalaires -= _salaire;
            _salaire = value;
            //TotalSalaires += value;
            TotalSalaires += _salaire;
        }
    }

    // auto-property => 1 propriété mais l'attribut est caché
    // utile si on ne fait rien de particulier au get ou au set de l'attribut en question
    public string Matricule { get; set; } = "000";
    public string Nom { get; set; } = "Salarié par défaut";
    public string Service { get; set; } = "Service par défaut";
    public string Categorie { get; set; } = "Catégorie par défaut";


    // le nombre total d’employés, le salaire total
    public static int NombreSalaries { get; private set; } = 0; // on ne pourra modifier le NombreSalaries qu'à l'intérieur de la classe, le setter est PRIVE
    public static decimal TotalSalaires { get; private set; } = 0;

    public static decimal MoyenneSalaires => TotalSalaires / NombreSalaries;

    public Salarie()
    {
        NombreSalaries++;
        Salaire = 16236; // SMIC pour les salariés par défaut
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
}