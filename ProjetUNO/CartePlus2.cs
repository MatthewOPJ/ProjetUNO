using System;

namespace ProjetUNO
{
    internal class CartePlus2 : Carte
    {
        public override void Jouer(ref Jeu jeu)
        {
            jeu.FairePigerProchain(2);
            jeu.JouerCarte(this);
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.Equals(couleur);
        }

        public override void Afficher()
        {
            Console.Write(couleur + "+2");
        }
    }
}