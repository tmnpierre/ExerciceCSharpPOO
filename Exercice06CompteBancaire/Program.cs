using Exercice06CompteBancaire.Classes;

namespace Exercice06CompteBancaire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CompteBancaire> listeComptes = new List<CompteBancaire>();
            Client client = new Client("John", "Doe", "JD123");
            bool continuer = true;

            while (continuer)
            {
                Console.Clear();
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1. Lister les comptes bancaires");
                Console.WriteLine("2. Créer un compte bancaire");
                Console.WriteLine("3. Effectuer un dépôt");
                Console.WriteLine("4. Effectuer un retrait");
                Console.WriteLine("5. Afficher les opérations et le solde");
                Console.WriteLine("0. Quitter le programme");
                Console.Write("Entrez votre choix : ");

                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        ListerComptes(listeComptes);
                        break;
                    case ConsoleKey.D2:
                        CreerCompte(listeComptes, client);
                        break;
                    case ConsoleKey.D3:
                        EffectuerDepot(listeComptes);
                        break;
                    case ConsoleKey.D4:
                        EffectuerRetrait(listeComptes);
                        break;
                    case ConsoleKey.D5:
                        AfficherOperationsEtSolde(listeComptes);
                        break;
                    case ConsoleKey.D0:
                        continuer = false;
                        break;
                }
            }
        }

        static void ListerComptes(List<CompteBancaire> listeComptes)
        {
            Console.Clear();
            Console.WriteLine("Liste des comptes:");
            foreach (var compte in listeComptes)
            {
                Console.WriteLine($"Compte: {compte.GetType().Name}, Solde: {compte.Solde}");
            }
            Pause();
        }

        static void CreerCompte(List<CompteBancaire> listeComptes, Client client)
        {
            Console.Clear();
            Console.WriteLine("Type de compte à créer:");
            Console.WriteLine("1. Compte courant");
            Console.WriteLine("2. Compte épargne");
            Console.WriteLine("3. Compte payant");
            Console.WriteLine("0. Retour");

            var key = Console.ReadKey();
            Console.Write("\nEntrez le solde initial: ");
            decimal soldeInitial = decimal.Parse(Console.ReadLine());

            switch (key.Key)
            {
                case ConsoleKey.D1:
                    listeComptes.Add(new CompteCourant(client, soldeInitial));
                    break;
                case ConsoleKey.D2:
                    listeComptes.Add(new CompteEpargne(client, soldeInitial));
                    break;
                case ConsoleKey.D3:
                    listeComptes.Add(new ComptePayant(client, soldeInitial));
                    break;
                case ConsoleKey.D0:
                    return;
            }
            Pause();
        }

        static void EffectuerDepot(List<CompteBancaire> listeComptes)
        {
            Console.Clear();
            if (listeComptes.Count == 0)
            {
                Console.WriteLine("Aucun compte bancaire disponible pour effectuer un dépôt.");
                Pause();
                return;
            }

            Console.WriteLine("Choisissez le compte pour le dépôt:");
            for (int i = 0; i < listeComptes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Compte {listeComptes[i].GetType().Name} - Solde: {listeComptes[i].Solde}");
            }
            Console.Write("Entrez le numéro du compte: ");
            int compteChoisi = Convert.ToInt32(Console.ReadLine()) - 1;

            if (compteChoisi < 0 || compteChoisi >= listeComptes.Count)
            {
                Console.WriteLine("Choix de compte invalide.");
                Pause();
                return;
            }

            Console.Write("Entrez le montant du dépôt: ");
            decimal montant = Convert.ToDecimal(Console.ReadLine());

            if (montant <= 0)
            {
                Console.WriteLine("Le montant du dépôt doit être positif.");
                Pause();
                return;
            }

            try
            {
                listeComptes[compteChoisi].Depot(montant);
                Console.WriteLine($"Dépôt de {montant} effectué avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du dépôt: {ex.Message}");
            }

            Pause();
        }

        static void EffectuerRetrait(List<CompteBancaire> listeComptes)
        {
            Console.Clear();
            if (listeComptes.Count == 0)
            {
                Console.WriteLine("Aucun compte bancaire disponible pour effectuer un retrait.");
                Pause();
                return;
            }

            Console.WriteLine("Choisissez le compte pour le retrait:");
            for (int i = 0; i < listeComptes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Compte {listeComptes[i].GetType().Name} - Solde: {listeComptes[i].Solde}");
            }
            Console.Write("Entrez le numéro du compte: ");
            int compteChoisi = Convert.ToInt32(Console.ReadLine()) - 1;

            if (compteChoisi < 0 || compteChoisi >= listeComptes.Count)
            {
                Console.WriteLine("Choix de compte invalide.");
                Pause();
                return;
            }

            Console.Write("Entrez le montant du retrait: ");
            decimal montant = Convert.ToDecimal(Console.ReadLine());

            if (montant <= 0)
            {
                Console.WriteLine("Le montant du retrait doit être positif.");
                Pause();
                return;
            }

            try
            {
                listeComptes[compteChoisi].Retrait(montant);
                Console.WriteLine($"Retrait de {montant} effectué avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du retrait: {ex.Message}");
            }

            Pause();
        }


        static void AfficherOperationsEtSolde(List<CompteBancaire> listeComptes)
        {
            Console.Clear();
            if (listeComptes.Count == 0)
            {
                Console.WriteLine("Aucun compte bancaire à afficher.");
                Pause();
                return;
            }

            Console.WriteLine("Choisissez le compte pour afficher les opérations et le solde:");
            for (int i = 0; i < listeComptes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Compte {listeComptes[i].GetType().Name} - Solde: {listeComptes[i].Solde}");
            }
            Console.Write("Entrez le numéro du compte: ");
            int compteChoisi = Convert.ToInt32(Console.ReadLine()) - 1;

            if (compteChoisi < 0 || compteChoisi >= listeComptes.Count)
            {
                Console.WriteLine("Choix de compte invalide.");
                Pause();
                return;
            }

            CompteBancaire compte = listeComptes[compteChoisi];
            Console.WriteLine($"\nOpérations pour le compte {compte.GetType().Name}:");
            foreach (var operation in compte.ListeOperations)
            {
                Console.WriteLine($"Numéro: {operation.Numero}, Montant: {operation.Montant}, Type: {operation.Statut}");
            }
            Console.WriteLine($"Solde actuel: {compte.Solde}");

            Pause();
        }


        static void Pause()
        {
            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}