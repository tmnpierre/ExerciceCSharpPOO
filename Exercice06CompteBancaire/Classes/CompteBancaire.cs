using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal abstract class CompteBancaire
    {
        public decimal Solde { get; protected set; }
        public string Client { get; private set; }
        public List<string> ListeOperations { get; private set; }

        protected CompteBancaire(string client, decimal soldeInitial)
        {
            Client = client;
            Solde = soldeInitial;
            ListeOperations = new List<string>();
        }

        public abstract void Depot(decimal montant);

        public abstract void Retrait(decimal montant);
    }
}
