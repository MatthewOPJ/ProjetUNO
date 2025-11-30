using System;

namespace ProjetUNO
{
    internal class CartePlus2 : Carte
    {
        public override void Jouer(ref Jeu jeu)
        {
            jeu.FairePigerProchain(2);
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CartePlus2);
        }

        public override string GetCode()
        {
            return $"{couleur}+2";
        }
    }
}