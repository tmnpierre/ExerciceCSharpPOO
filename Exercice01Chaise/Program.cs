using Exercice01Chaise.Classe;

internal class Program
{
    private static void Main(string[] args)
    {
        Chaise une = new Chaise(4, "bois", "blanche");
        Chaise deux = new Chaise(2, "metal", "noire");
        Chaise trois = new Chaise(6, "plastique", "bleue");

        List<Chaise> mesChaises = new List<Chaise> { une, deux, trois };

        foreach (Chaise chaise in mesChaises)
        {
            Console.WriteLine(chaise);
        }
    }
}
