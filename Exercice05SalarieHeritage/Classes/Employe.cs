namespace Exercice05SalarieHeritage.Classes
{
    public class Employe : Salarie
    {
        public Employe(string matricule, string nom, string service, string categorie, decimal salaire)
            : base(matricule, nom, service, categorie, salaire)
        {
        }

        public override void AfficherSalaire()
        {
            base.AfficherSalaire();
        }

        public override string ToString()
        {
            return $"Employe: Matricule: {Matricule}, Nom: {Nom}, Service: {Service}, Catégorie: {Categorie}, Salaire: {Salaire}";
        }
    }
}