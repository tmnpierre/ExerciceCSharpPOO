using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class Client
    {
        public string Prenom {  get; set; }
        public string Nom { get; set; }
        public string Identifiant { get; set; }
        public List<string> ListeCompte { get; private set; }
    }
}
