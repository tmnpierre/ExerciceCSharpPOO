using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04Pendu.Classes
{
    internal class Pendu
    {
        private readonly string _motATrouver;
        private string _masque;
        private readonly int _nbVies;
        private int _nbTentatives;
        private readonly List<string> _lettresTestees;

        public string MotATrouver { get => _motATrouver; }
        public string Masque { get => _masque; }
        public int NbVies { get => _nbVies; }
        public int NbTentatives { get => _nbTentatives; }
        public List<string> LettresTestees { get => _lettresTestees; }

        public Pendu()
        {
            // On génère le mot à trouver via la classe prévue à cet effet
            _motATrouver = GenerateurDeMots.Generer();

            // L'affichage du masque sera généré via une méthode privée
            _masque = GenererMasque();

            // Pour éviter les erreurs de nullabilité futures, on initialise la liste vide
            _lettresTestees = new();

            // Par défaut, on a 10 vies
            _nbVies = 10;

            // On initialise la valeur de type int à 0 par mesure de sécurité
            _nbTentatives = 0;
        }

        private string GenererMasque()
        {
            // On créé une chaine de caractère vide
            string tmp = "";

            // Pour chaque lettre présente dans le mot à trouver
            foreach (char letter in _motATrouver)
            {
                // On ajoute à notre chaine un astérisque
                tmp += "*";
            }

            // On retourne la chaine d'astérisque, qui devient le masque initial
            return tmp;
        }

        public int TestWin()
        {
            // Si le masque n'a plus de caractères masqués, c'est qu'on a trouvé toutes les lettres du mot, on a donc gagné
            if (!_masque.Contains("*")) return 1;

            // Sinon, on regarde combien de vie il nous reste. Si l'on en a plus, on a perdu
            if (_nbTentatives >= _nbVies) return -1;

            // Enfin, dans tous les cas restants, on continue de jouer
            return 0;
        }

        public void TestChar(char lettre)
        {
            // On va passer la lettre envoyée en paramètre en tant que lettre majuscule
            string aTester = lettre.ToString().ToUpper();

            // On vérifie que notre listing de lettres testées par l'utilisateur ne contient pas déjà cette lettre
            if (!_lettresTestees.Contains(aTester))
            {
                // On génère une chaine vide
                string tmpMask = "";

                // On créé un booléen pour vérifier par la suite si l'on a trouvé une lettre ou non
                bool flag = false;

                // On parcourt les indices de notre mot à trouver
                for (int i = 0; i < _motATrouver.Length; i++)
                {
                    // Si à cet emplacement la lettre est la même que celle envoyée par l'utilisateur...
                    if (_motATrouver[i].ToString() == aTester)
                    {
                        // On ajoute à notre chaine temporaire la lettre
                        tmpMask += aTester;

                        // On passe le booléen à true
                        flag = true;
                    }
                    else // Sinon...
                    {
                        // On ajoute la valeur du masque à cette position
                        tmpMask += _masque[i];
                    }
                }

                // Si le flag n'est jamais passé à true durant la boucle, alors on avait pas trouvé de lettre comprise dans le mot à trouver. On perd donc une vie
                if (!flag) _nbTentatives++;

                // On ajoute la lettre à la liste des lettres testées pour en garder la trace et informer l'utilisateur
                _lettresTestees.Add(aTester);

                // On remplace le masque affiché à l'utilisateur par le masque temporaire créé durant l'itération
                _masque = tmpMask;
            }
        }
    }
}
