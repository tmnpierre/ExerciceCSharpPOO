namespace Exercice06CompteBancaire.Classes
{
    internal class Operation
    {
        public int Numero { get; set; }
        public decimal Montant { get; set; }
        public enum TypeOperation { Retrait, Depot }
        public TypeOperation Statut { get; set; }

        public Operation(int numero, decimal montant, TypeOperation statut)
        {
            Numero = numero;
            Montant = montant;
            Statut = statut;
        }
    }
}