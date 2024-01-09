namespace Exercice06CompteBancaire.Classes
{
    internal class Client
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Identifiant { get; set; }
        public List<CompteBancaire> ListeCompte { get; private set; }

        public Client(string prenom, string nom, string identifiant)
        {
            Prenom = prenom;
            Nom = nom;
            Identifiant = identifiant;
            ListeCompte = new List<CompteBancaire>();
        }

        public void AjouterCompte(CompteBancaire compte)
        {
            ListeCompte.Add(compte);
        }
    }
}
