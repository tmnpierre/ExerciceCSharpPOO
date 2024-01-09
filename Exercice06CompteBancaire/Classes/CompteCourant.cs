namespace Exercice06CompteBancaire.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant(Client client, decimal soldeInitial) : base(client, soldeInitial)
        {
        }

        public override void Depot(decimal montant)
        {
            throw new NotImplementedException();
        }

        public override void Retrait(decimal montant)
        {
            throw new NotImplementedException();
        }
    }
}
