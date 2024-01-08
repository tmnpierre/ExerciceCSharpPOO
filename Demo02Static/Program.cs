using Demo02Static.Classes;

Console.WriteLine(Dinosaur.NombreDeDinos);

Dinosaur[] dinoArray = {
    new Dinosaur(),
    new Dinosaur(),
    new Dinosaur("Denver", 10, "Corythosaurus"),
    new Dinosaur("Petit-Pied", 12, "Apatosaurus", true)
};

Console.WriteLine(Dinosaur.NombreDeDinos);


Dinosaur.AfficherDinosaurVivants();

Dinosaur.AfficherDinosaurCrees();