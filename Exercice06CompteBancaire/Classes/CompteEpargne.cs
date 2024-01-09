namespace Exercice06CompteBancaire.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        private decimal tauxInteret;

        public CompteEpargne(Client client, decimal solde, decimal tauxInteret = 0.02m) : base(client, solde)
        {
            this.tauxInteret = tauxInteret;
        }

        public override void Depot(decimal montant)
        {
            Solde += montant;
            ListeOperations.Add(new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Depot));
        }

        public override void Retrait(decimal montant)
        {
            if (Solde >= montant)
            {
                Solde -= montant;
                ListeOperations.Add(new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Retrait));
            }
            else
            {
                throw new InvalidOperationException("Fonds insuffisants pour ce retrait.");
            }
        }

        public void AppliquerInteret()
        {
            Solde += Solde * tauxInteret;
        }
    }
}