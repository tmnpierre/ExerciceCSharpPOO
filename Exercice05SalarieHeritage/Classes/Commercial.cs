namespace Exercice05SalarieHeritage.Classes
{
    internal class Commercial : Salarie
    {
        private decimal _chiffreAffaire;
        private decimal _commisionPrct;

        public decimal ChiffreAffaire { get; }
        public decimal CommisionPrct { get; }

        public Commercial(string matricule, string nom, string service, string categorie, decimal salaire, decimal chiffreAffaire, decimal commisionPrct) : base(matricule, nom, service, categorie, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            CommisionPrct = commisionPrct;
        }

        public override void AfficherSalaire()
        {
            var comision = _chiffreAffaire * (_chiffreAffaire / 100);
            Console.WriteLine($"Le salaire de {Nom} avec commision est de {comision + Salaire}");
        }
    }
}
