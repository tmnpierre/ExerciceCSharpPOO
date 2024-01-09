namespace Exercice06CompteBancaire.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        public CompteEpargne(Client client, decimal soldeInitial) : base(client, soldeInitial)
        {
        }

        public override void Depot(decimal montant)
        {
            Solde += montant;
            var operation = new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Depot);
            ListeOperations.Add(operation);
        }

        public override void Retrait(decimal montant)
        {
            Solde -= montant;
            var operation = new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Retrait);
            ListeOperations.Add(operation);
        }
    }
}
