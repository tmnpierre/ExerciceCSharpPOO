public class Personne
{
    public string Nom { get; }
    public string Prenom { get; }
    public int Age { get; }

    public Personne(string nom, string prenom, int age)
    {
        Nom = nom;
        Prenom = prenom;
        Age = age;
    }

    public override string ToString() => $"{Nom} {Prenom}, {Age} ans";
}

