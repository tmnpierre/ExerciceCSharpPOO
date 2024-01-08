namespace Exercice05SalarieHeritage.Classes
{
    internal class Commercial : Salarie
    {
        private decimal _chiffreAffaire;
        private decimal _commissionPrct;

        public decimal ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public decimal CommissionPrct { get => _commissionPrct; set => _commissionPrct = value; }

        public Commercial(string matricule, string nom, string service, string categorie, decimal salaire, decimal chiffreAffaire, decimal commissionPrct)
            : base(matricule, nom, service, categorie, salaire)
        {
            _chiffreAffaire = chiffreAffaire;
            _commissionPrct = commissionPrct;
        }

        public override void AfficherSalaire()
        {
            var commission = _chiffreAffaire * (_commissionPrct / 100);
            Console.WriteLine($"Le salaire de {Nom} avec commission est de {commission + Salaire}");
        }

        public override string ToString()
        {
            return $"Commercial: Matricule: {Matricule}, Nom: {Nom}, Service: {Service}, Catégorie: {Categorie}, Salaire: {Salaire}, Chiffre d'Affaire: {_chiffreAffaire}, Commission: {_commissionPrct}%";
        }
    }
}
