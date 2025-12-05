using System;
using System.Runtime.CompilerServices;

namespace ProjetUNO
{
    internal class CarteWild : Carte
    {

        public CarteWild(char couleur) : base(couleur)
        {

        }

        //Nous permet de choisir entre les 4 couleurs.
        public void ChoisirCouleur()
        {
            while (true)
            {
                Console.WriteLine("Veuillez choisir une couleur: ");
                Console.WriteLine("B pour Bleu.");
                Console.WriteLine("J pour Jaune.");
                Console.WriteLine("R pour Rouge.");
                Console.WriteLine("V pour Vert.\n");

                char choix = Console.ReadKey().KeyChar;

                switch (choix)
                {
                    case 'B':
                    case 'J':
                    case 'R':
                    case 'V': couleur = choix; Console.WriteLine(); return;
                    default: Console.WriteLine("Entrée invalid."); break;
                }
            }
        }

        //Choisir la couleur avant de jouer la carte.
        public override void Jouer(Jeu jeu)
        {
            ChoisirCouleur();
            jeu.JouerCarte(this);
        }

        public override bool PeutJouer(Carte topPile)
        {
            return true; //Vue que c'est une carte Wild elle peut être jouée à tout moment
        }

        public override string GetCode()
        {
            return $"{couleur}";
        }
    }
}