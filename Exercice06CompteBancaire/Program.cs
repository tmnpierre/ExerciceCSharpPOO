﻿using Exercice06CompteBancaire.Classes;

var continuer = true;

Console.WriteLine("=== Menu Principal === \n");
Console.WriteLine("1. Lister les comptes bancaire");
Console.WriteLine("2. Creer un compte bancaire");
Console.WriteLine("3. Effectuer un depot");
Console.WriteLine("4. Effectuer un retrait");
Console.WriteLine("5. Afficher les opérations et le solde");
Console.WriteLine("0. Quitter le programme \n");
Console.Write("Entrez votre choix : ");
var choose = Console.ReadLine();

while (continuer)
{
    switch (choose)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "0":
            continuer = false;
            break;
    }
}

static void CreerCompte (List<CompteBancaire> ListeCompte)
{
    Console.Clear();
    Console.WriteLine("1. Créer un compte courant");
    Console.WriteLine("2. Créer un compte épargne");
    Console.WriteLine("3. Créer un compte payant");
    Console.WriteLine("0. Retour au menu principal \n");
    Console.Write("Entrez votre choix : ");
    var choose = Console.ReadLine();
    switch (choose)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            break;
        case "0":
            break;
    }
}