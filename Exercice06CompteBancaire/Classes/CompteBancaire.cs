using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal abstract class CompteBancaire
    {
        public double Solde { get; protected set; }
        public string Client { get; private set; }
        public List<string> ListeOperations { get; private set; }
    }
}
