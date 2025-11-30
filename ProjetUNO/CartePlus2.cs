using System;

namespace ProjetUNO
{
    internal class CartePlus2 : Carte
    {
        public override void Jouer(ref Jeu jeu)
        {
            jeu.FairePigerProchain(2);
        }

        public override bool PeutJouer(Carte topPile)
        {
            return true;
        }

        public override void Afficher()
        {

        }
    }
}