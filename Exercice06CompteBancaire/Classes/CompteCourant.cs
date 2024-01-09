namespace Exercice06CompteBancaire.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant(Client client, decimal solde) : base(client, solde) { }

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
    }
}