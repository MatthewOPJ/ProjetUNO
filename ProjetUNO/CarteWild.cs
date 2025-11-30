using System;
using System.Runtime.CompilerServices;

namespace ProjetUNO
{
    internal class CarteWild : Carte
    {
        //Nous permet de choisir entre les 4 couleurs.
        public void ChoisirCouleur()
        {
            while (true)
            {

                Console.WriteLine("Veuillez choisir une couleur: ");
                Console.WriteLine("B pour Bleu.");
                Console.WriteLine("J pour Jaune.");
                Console.WriteLine("R pour Rouge.");
                Console.WriteLine("V pour Vert.");

                char choix = Console.ReadKey().KeyChar;

                switch (choix)
                {
                    case 'B':
                    case 'J':
                    case 'R':
                    case 'V': couleur = choix; Console.WriteLine(); return;
                    default: Console.WriteLine(); Console.WriteLine("Entrée invalid."); break;
                }
            }
            
        }

        public override void Jouer(ref Jeu jeu){

        }

        public override bool PeutJouer(Carte topPile)
        {
            return true;
        }

        public override void Afficher(){

        }
    }
}