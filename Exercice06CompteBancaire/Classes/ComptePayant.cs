namespace Exercice06CompteBancaire.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        public decimal coutDepot = 0.95m;
        public decimal coutRetrait = 1.05m; 
        public ComptePayant(Client client, decimal solde) : base(client, solde)
        {
        }

        public override void Depot(decimal montant)
        {
            Solde += montant * coutDepot;
            var operation = new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Depot);
            ListeOperations.Add(operation);
        }

        public override void Retrait(decimal montant)
        {
            Solde -= montant * coutRetrait;
            var operation = new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Retrait);
            ListeOperations.Add(operation);
        }
    }
}
