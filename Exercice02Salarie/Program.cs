using Exercice02Salarie;
internal class Program
{
    private static void Main(string[] args)
    {
        Salarie chloe = new Salarie("1214", "Service1", "Chloé", 24000);
        Salarie emma = new Salarie("1215", "Service2", "Emma", 30000);
        Salarie georges = new Salarie("1216", "Service3", "George", 26000);
        Salarie employeParDefaut = new Salarie();

        List<Salarie> salaries = new List<Salarie> { chloe, emma, georges, employeParDefaut };

        Console.WriteLine("Informations des salariés initiales: \n");
        AfficherEtCalculerSalaires(salaries);

        Console.WriteLine("On change le salaire de Chloé à 500000. \n");
        chloe.Salaire = 500000; 

        Console.WriteLine("Informations des salariés après modification: \n ");
        AfficherEtCalculerSalaires(salaries);

        salaries.Clear();
        Salarie.ResetNbSalarie();
        Salarie.ResetTotalSalaires();

        Console.WriteLine("La liste des salariés et les salaires ont été réinitialisés.");
    }

    private static void AfficherEtCalculerSalaires(List<Salarie> salaries)
    {
        double sumSalaires = 0;
        foreach (Salarie salarie in salaries)
        {
            Console.WriteLine(salarie);
            sumSalaires += salarie.Salaire;
        }

        int count = salaries.Count;
        double moyenneSalaires = count > 0 ? sumSalaires / count : 0;

        Console.WriteLine($"Nombre total de salariés : {count}");
        Console.WriteLine($"La somme des salaires est de : {sumSalaires}");
        Console.WriteLine($"La moyenne des salaires est de : {moyenneSalaires}\n");
    }
}
