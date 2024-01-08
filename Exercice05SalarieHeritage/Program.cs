using Exercice05SalarieHeritage.Classes;

Console.WriteLine("--- Gestion des employés --- \n");

bool continuer = true;

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
            Console.Clear();
            Console.WriteLine("--- Ajouter un employé --- \n");

            bool continuer2 = true;
            while (continuer2)
            {
                Console.WriteLine("1 -- Salarié");
                Console.WriteLine("2 -- Commercial");
                Console.WriteLine("3 -- Retour \n");
                Console.Write("Entrez votre choix : ");
                var choose2 = Console.ReadLine();

                switch (choose2)
                {
                    case "1":
                        // Logic for adding a Salarié
                        break;
                    case "2":
                        // Logic for adding a Commercial
                        break;
                    case "3":
                        continuer2 = false;
                        Console.Clear();
                        break;
                }
            }
            break;
        case "2":
            // Display employee salaries
            break;
        case "3":
            // Search for an employee
            break;
        case "0":
            continuer = false;
            break;
    }
}

Salarie jeanMichel = new Commercial("004", "Jean-Michel", "Commercial", "Cadre", 1300, 13000, 3);

List<Salarie> salaries = new() {
jeanMichel,
new Salarie("001", "Chloé", "Comptabilité", "Cadre", 24000),
new Salarie("002", "Emma", "Comptabilité", "Employée", 30000),
new Salarie("003", "Georges", "Developpement", "Employé", 26000),
new Salarie(),
};

foreach (Salarie salarie in salaries)
{
    salarie.AfficherSalaire();
}



Console.WriteLine("Nombre de salariés : " + Salarie.NombreSalaries);

Console.WriteLine("On change le salaire de Chloé à 500000.");
salaries[0].Salaire = 500000;

Console.WriteLine("Nombre de salariés : " + Salarie.NombreSalaries);
Console.WriteLine("Salaire total : " + Salarie.TotalSalaires);

Console.WriteLine("Remise à zéro des salariés et salaire total.");
Salarie.RemiseAZero();

Console.WriteLine("Nombre de salariés : " + Salarie.NombreSalaries);
Console.WriteLine("Salaire total : " + Salarie.TotalSalaires);

