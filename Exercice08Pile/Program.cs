class Program
{
    static void Main()
    {
        var pileDeStrings = new Pile<string>();
        var pileDeDecimals = new Pile<decimal>();
        var pileDePersonnes = new Pile<Personne>();

        bool continuer = true;
        while (continuer)
        {
            Console.Clear();
            AfficherMenu();

            string choix = Console.ReadLine();
            switch (choix)
            {
                case "1":
                    Console.WriteLine("Entrez une valeur à empiler : ");
                    string valeur = Console.ReadLine();
                    pileDeStrings.Empiler(valeur);
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine($"Valeur dépilée : {pileDeStrings.Depiler()}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "3":
                    Console.WriteLine("Entrez l'indice de l'élément à récupérer : ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        try
                        {
                            Console.WriteLine($"Valeur trouvée : {pileDeStrings.Recuperer(index)}");
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Indice invalide !");
                    }
                    break;
                case "0":
                    continuer = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    break;
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }

    static void AfficherMenu()
    {
        Console.WriteLine("=== Menu Principal ===");
        Console.WriteLine("1. Empiler");
        Console.WriteLine("2. Dépiler");
        Console.WriteLine("3. Récupérer à x");
        Console.WriteLine("0. Quitter");
        Console.Write("Votre choix : ");
    }
}