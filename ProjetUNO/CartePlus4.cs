using System;

namespace ProjetUNO
{
    internal class CartePlus4 : CarteWild
    {


        public override void Jouer(ref Jeu jeu)
        {
            ChoisirCouleur();
            jeu.FairePigerProchain(4);
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return true;
        }

        public override void Afficher()
        {
            Console.Write(couleur + "+4");
        }
    }
}