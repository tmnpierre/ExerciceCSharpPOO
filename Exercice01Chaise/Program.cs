using Exercice01Chaise.Classe;

internal class Program
{
    private static void Main(string[] args)
    {
        Chaise une = new Chaise(4, "bois", "blanche");
        une.Afficher();
        Chaise deux = new Chaise(2, "metal", "noire");
        deux.Afficher();
        Chaise trois = new Chaise(6, "plastique", "bleue");
        trois.Afficher();
    }
}