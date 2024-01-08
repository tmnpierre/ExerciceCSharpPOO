using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Classes.Classes;

internal class Dinosaur
{
    // Attributs
    private int _age = 5;
    private string _espece;
    private int _nbPattes;
    private double _poids;
    private bool _peutVoler = false;

    // Propriétés
    public int Age
    {
        get => _age;
        set => _age = value;
    }
    public string Espece { get => _espece; set => _espece = value; }
    public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
    public double Poids
    {
        get
        {
            Console.WriteLine("_poids à été récupéré, il vaut " + _poids);
            return _poids;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("La valeur passée au poids est invalide !!! Je le met donc à 100 kg.");
                _poids = 100;
            }
            else
                _poids = value;
        }
    }
    public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }

    //public string AgeEspece { get => $"{_age} {_espece}";}
    public string AgeEspece { get => $"{Age} {Espece}"; } // on repasse par les propriétés



    // ici on a des propriétés avec des attributs private implicites, on ne les a pas déclaré, on a pas de "_regimeAlimentaire" et "_nom"
    // c'est une version abrégée/simplifiée du concept d'encapsulation
    public string RegimeAlimentaire { get; set; } = "Herbivore";
    public string Nom { get; set; }


    // Constructeurs (crée une nouvelle instance de Dinosaur)
    public Dinosaur() //constructeur par défaut, il est vide, si on ne le crée pas, c# le crée implicitement
    {
        Nom = "Dinosaur par défaut";
        Espece = "Espèce par défaut";
        //_age = 120; // on définit l'age directement par l'attribut
        Age = 120; // on définit l'age par la propriété, si la propriété faisait des choses en plus (vérifications, ...) il serait plus avantageux de passer par elle
    }

    public Dinosaur(string nom, int age, string espece, bool peutVoler) // ici on a des paramètres d'entrées du constructeur
    {
        this.Nom = nom;// équivalent : Nom = nom;
        Age = age;
        Espece = espece;
        PeutVoler = peutVoler;
    }


    // Méthodes
    public void Afficher()
    {
        Console.WriteLine($"Le Dinosaur {this.Nom} est agé de {Age} ans et est de l'espèce {Espece}");
    }

    public void Crier()
    {
        Console.WriteLine($"Le Dinosaur {Nom} crie !");
    }

    /// <summary>
    /// Permet à un dino de s'envoler (si il peut...)
    /// </summary>
    public void SEnvoler()
    {
        if (PeutVoler)
        {
            Console.WriteLine($"Le Dinosaur {Nom} s'envole majestueusement !");
            return;
        }
        Console.WriteLine($"Le Dinosaur {Nom} saute et s'écrase lamentablement...");
    }
}
