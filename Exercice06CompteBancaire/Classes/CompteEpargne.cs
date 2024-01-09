using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        public CompteEpargne(string client, decimal soldeInitial) : base(client, soldeInitial)
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
