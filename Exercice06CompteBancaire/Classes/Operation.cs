namespace Exercice06CompteBancaire.Classes
{
    internal class Operation
    {
        public int Numero { get; private set; }
        public decimal Montant { get; private set; }
        public TypeOperation Statut { get; private set; }

        public Operation(int numero, decimal montant, TypeOperation statut)
        {
            Numero = numero;
            Montant = montant;
            Statut = statut;
        }

        public enum TypeOperation
        {
            Retrait,
            Depot
        }
    }
}