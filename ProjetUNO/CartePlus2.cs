using System;

namespace ProjetUNO
{
    internal class CartePlus2 : Carte
    {
        public CartePlus2(char couleur) : base(couleur)
        {
        }

        public override void Jouer(Jeu jeu)
        {
            jeu.FairePigerProchain(2);
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CartePlus2);//vérifie si la couleur est la même ou si la carte du dessus est aussi une carte Plus 2
        }

        public override string GetCode()
        {
            return $"{couleur}+2";
        }
    }
}