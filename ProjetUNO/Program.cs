using System;

namespace ProjetUNO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AfficherRegles();
            Jeu jeu = new Jeu();
            jeu.Jouer();
            Console.WriteLine("");
        }

        static void AfficherRegles()
        {
            Console.WriteLine("------ Bienvenue au jeu d'Uno ! ------");
            Console.WriteLine("Voici les règles pour savoir comment jouer !: ");

            Console.WriteLine();

            Console.WriteLine("--> Il y a 3 joueurs et chaque joueurs commencent avec 5 cartes.");
            Console.WriteLine("--> Le jeu s'arrête automatiquement quand 1 des 3 joueurs a aucune cartes restantes.");
            Console.WriteLine("--> Si quelqu'un joues une carte +4 ou +2 vous passez votre tour également.");
            Console.WriteLine("--> Le joueur peut jouer plus d'une carte avec le même chiffre.");

            Console.WriteLine();

            Console.WriteLine("Voici les codes de cartes: ");
            Console.WriteLine("--> 'B': bleu, 'J': jaune, 'R': rouge et 'V': vert sont les couleurs.");
            Console.WriteLine("--> 'CDS': changer de sens, 'PT': passer tour, '+2': faire piger 2 cartes. ");
            Console.WriteLine("'W': choisir la couleur, '+4': faire piger 4 cartes et choisir la couleur");

            Console.WriteLine();
            Console.WriteLine("--> Il faut écrire la couleur en premier et le chiffre ou l'action en deuxième.");
            Console.WriteLine("EX: 'V+2': faire piger 2 cartes qui est vert, 'BCSD': changer de sens est bleu, etc.");
            Console.WriteLine();

            Console.WriteLine("Appuyer sur un bouton pour débuter la partie !");
            Console.ReadLine();
            Console.Clear();
        }
    }
}