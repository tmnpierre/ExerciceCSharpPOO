using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class Operation
    {
        public int numero {  get; set; }
        public decimal montant {  get; set; }
        public enum Statut {retrait, debot};
        public Statut statut { get; set; }
        public Operation(int numero, decimal montant, Statut statut)
        {
            this.numero = numero;
            this.montant = montant;
            this.statut = statut;
        }

    }
}
