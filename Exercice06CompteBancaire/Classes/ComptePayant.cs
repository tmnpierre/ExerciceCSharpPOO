namespace Exercice06CompteBancaire.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        private decimal fraisOperation;

        public ComptePayant(Client client, decimal solde, decimal fraisOperation = 1.00m) : base(client, solde)
        {
            this.fraisOperation = fraisOperation;
        }

        public override void Depot(decimal montant)
        {
            if (montant > fraisOperation)
            {
                Solde += montant - fraisOperation;
                ListeOperations.Add(new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Depot));
            }
            else
            {
                throw new InvalidOperationException("Le montant doit être supérieur aux frais d'opération.");
            }
        }

        public override void Retrait(decimal montant)
        {
            decimal montantAvecFrais = montant + fraisOperation;
            if (Solde >= montantAvecFrais)
            {
                Solde -= montantAvecFrais;
                ListeOperations.Add(new Operation(ListeOperations.Count + 1, montant, Operation.TypeOperation.Retrait));
            }
            else
            {
                throw new InvalidOperationException("Fonds insuffisants pour ce retrait.");
            }
        }
    }
}