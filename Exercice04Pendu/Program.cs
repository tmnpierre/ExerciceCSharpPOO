using Exercice04Pendu.Classes;

// On créé un nouveau jeu du pendu
Pendu lePendu = new();

// Tant qu'on a ni gagné ni perdu,on joue 
while (lePendu.TestWin() == 0)
{
    // On fait un affichage user friendly avec informations issues des propriétés de la classe
    Console.WriteLine($"Lettres testées: [{string.Join(", ", lePendu.LettresTestees)}]");
    Console.WriteLine($"Tentatives: ({lePendu.NbTentatives}/{lePendu.NbVies})");
    Console.WriteLine($"Mot à trouver: {lePendu.Masque}");

    // Un message indicatif de ce que le programme attend
    Console.WriteLine("\nVeuillez entrer une lettre: ");

    // On récupère seulement la première lettre
    char lettre = Console.ReadLine()[0];

    // On envoie la lettre récupérée 
    lePendu.TestChar(lettre);
}

// Si l'on a gagné, on en informe l'utilisateur
if (lePendu.TestWin() == 1) Console.WriteLine("Bravo, vous avez trouvé le mot !");

// S'il a perdu, on va lui fournir le mot qu'il devait trouver
else Console.WriteLine("Dommage, le mot à trouver était " + lePendu.MotATrouver);