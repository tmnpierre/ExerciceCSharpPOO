using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04Pendu.Classes
{
    internal class GenerateurDeMots
    {
        public static List<string> listeMots = new()
        {
            "amazon",
            "microsoft",
            "sephora",
            "activision",
            "nutella",
            "arbre",
            "banane",
            "chien",
            "chat",
            "television"
        };

        public static string Generer()
        {
            // Génération d'un nombre aléatoire allant de 0 à la taille de notre liste 'exclue' pour éviter les problèmes de Null
            var nombreAlea = new Random().Next(listeMots.Count);

            // On retourne l'un des mots de notre liste via utilisation de l'index obtenu aléatoirement juste au dessus
            return listeMots[nombreAlea].ToUpper();
        }
    }
}
