using Demo01Classes.Classes;

//Dinosaur dinosaur = new Dinosaur();

//Console.WriteLine(dinosaur);
//Console.WriteLine(dinosaur.Age);
//dinosaur.Age = 160;
//Console.WriteLine(dinosaur.Age);

//dinosaur.Poids = 16;
//Console.WriteLine(dinosaur.Poids);
//dinosaur.Poids = -16;
//Console.WriteLine(dinosaur.Poids);



//// instanciation => appel au constructeur
//Dinosaur monDino = new Dinosaur(); // ici le constructeur par défaut car pas de paramêtres

//Console.WriteLine(monDino.Nom);
//Console.WriteLine(monDino.Age);

//Console.WriteLine("---------------------");

//Console.WriteLine("Set des valeurs :");
//monDino.Age = 10;
//monDino.Poids = 100;

//Console.WriteLine("---------------------");

//Console.WriteLine("write de l'age : " + monDino.Age);
//Console.WriteLine("write du poids : " + monDino.Poids);

//Console.WriteLine("---------------------");

//Console.WriteLine("Set d'un poids invalide :");
//monDino.Poids = -100;

//Console.WriteLine("---------------------");



// Utilisations de constructeurs (instanciations)

Dinosaur monDino = new Dinosaur();
Dinosaur monDino2 = new Dinosaur();
Dinosaur denver = new Dinosaur("Denver", 10, "Corythosaurus", false);
Dinosaur petitPied = new Dinosaur("Petit-Pied", 12, "Apatosaurus", true);
var encorUnDino = new Dinosaur("Guillausaur", 38, "Humain", true);

Console.WriteLine($"Le Dinosaur {monDino.Nom} est agé de {monDino.Age} ans et est de l'espèce {monDino.Espece}");
Console.WriteLine($"Le Dinosaur {monDino2.Nom} est agé de {monDino2.Age} ans et est de l'espèce {monDino2.Espece}");
Console.WriteLine($"Le Dinosaur {denver.Nom} est agé de {denver.Age} ans et est de l'espèce {denver.Espece}");
Console.WriteLine($"Le Dinosaur {petitPied.Nom} est agé de {petitPied.Age} ans et est de l'espèce {petitPied.Espece}");
Console.WriteLine($"Le Dinosaur {encorUnDino.Nom} est agé de {encorUnDino.Age} ans et est de l'espèce {encorUnDino.Espece}");

Console.WriteLine("---------------------");

denver.Afficher();
petitPied.Crier();

Console.WriteLine("---------------------");

monDino.SEnvoler();
denver.SEnvoler();
petitPied.SEnvoler();
encorUnDino.SEnvoler();