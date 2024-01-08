using Exercice05SalarieHeritage.Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Gestion des employés --- \n");

        bool continuer = true;
        List<Salarie> salaries = new List<Salarie>();

        while (continuer)
        {
            Console.Clear();
            Console.WriteLine("1 -- Ajouter un employé");
            Console.WriteLine("2 -- Afficher le salaire des employés");
            Console.WriteLine("3 -- Rechercher un employé");
            Console.WriteLine("0 -- Quitter \n");
            Console.Write("Entrez votre choix : ");
            var choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    AjouterEmploye(salaries);
                    break;
                case "2":
                    AfficherSalaires(salaries);
                    break;
                case "3":
                    RechercherEmploye(salaries);
                    break;
                case "0":
                    continuer = false;
                    break;
            }
        }
    }

    static void AjouterEmploye(List<Salarie> salaries)
    {
        Console.Clear();
        Console.WriteLine("--- Ajouter un employé --- \n");

        Console.WriteLine("1 -- Employé");
        Console.WriteLine("2 -- Commercial");
        Console.Write("Entrez votre choix : ");
        var choose2 = Console.ReadLine();

        switch (choose2)
        {
            case "1":
                salaries.Add(CreerEmploye());
                break;
            case "2":
                salaries.Add(CreerCommercial());
                break;
        }
    }

    static Salarie CreerEmploye()
    {
        Console.Clear();
        Console.WriteLine("Création d'un nouvel employé.");
        Console.Write("Entrez le matricule : ");
        string matricule = Console.ReadLine();

        Console.Write("Entrez le nom : ");
        string nom = Console.ReadLine();

        Console.Write("Entrez le service : ");
        string service = Console.ReadLine();

        Console.Write("Entrez la catégorie : ");
        string categorie = Console.ReadLine();

        Console.Write("Entrez le salaire : ");
        decimal salaire;
        while (!decimal.TryParse(Console.ReadLine(), out salaire))
        {
            Console.Write("Veuillez entrer un nombre valide pour le salaire : ");
        }

        return new Employe(matricule, nom, service, categorie, salaire);
    }

    static Salarie CreerCommercial()
    {
        Console.Clear();
        Console.WriteLine("Création d'un nouveau commercial.");
        Console.Write("Entrez le matricule : ");
        string matricule = Console.ReadLine();

        Console.Write("Entrez le nom : ");
        string nom = Console.ReadLine();

        Console.Write("Entrez le service : ");
        string service = Console.ReadLine();

        Console.Write("Entrez la catégorie : ");
        string categorie = Console.ReadLine();

        Console.Write("Entrez le salaire : ");
        decimal salaire;
        while (!decimal.TryParse(Console.ReadLine(), out salaire))
        {
            Console.Write("Veuillez entrer un nombre valide pour le salaire : ");
        }

        Console.Write("Entrez le chiffre d'affaire : ");
        decimal chiffreAffaire;
        while (!decimal.TryParse(Console.ReadLine(), out chiffreAffaire))
        {
            Console.Write("Veuillez entrer un nombre valide pour le chiffre d'affaire : ");
        }

        Console.Write("Entrez le pourcentage de commission : ");
        decimal commissionPrct;
        while (!decimal.TryParse(Console.ReadLine(), out commissionPrct))
        {
            Console.Write("Veuillez entrer un nombre valide pour le pourcentage de commission : ");
        }

        return new Commercial(matricule, nom, service, categorie, salaire, chiffreAffaire, commissionPrct);
    }

    static void AfficherSalaires(List<Salarie> salaries)
    {
        Console.Clear();
        foreach (var salarie in salaries)
        {
            salarie.AfficherSalaire();
        }
        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
        Console.ReadKey();
    }

    static void RechercherEmploye(List<Salarie> salaries)
    {
        Console.Clear();
        Console.Write("Entrez le début du nom de l'employé : ");
        string recherche = Console.ReadLine().ToLower();

        bool employeTrouve = false;

        foreach (var salarie in salaries)
        {
            if (salarie.Nom.ToLower().StartsWith(recherche))
            {
                string typeEmploye = salarie is Commercial ? "Commercial" : "Employé";
                Console.WriteLine($"Employé trouvé : {salarie.Nom}, Service : {salarie.Service}, Type : {typeEmploye}");
                employeTrouve = true;
            }
        }

        if (!employeTrouve)
        {
            Console.WriteLine("Aucun employé trouvé avec ce nom.");
        }

        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
        Console.ReadKey();
    }
}