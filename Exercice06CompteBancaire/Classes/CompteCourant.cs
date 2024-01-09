﻿namespace Exercice06CompteBancaire.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant(Client client, decimal solde) : base(client, solde)
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
