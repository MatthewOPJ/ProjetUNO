using System;

namespace ProjetUNO
{
    internal class CartePlus4 : CarteWild
    {
        public CartePlus4(char couleur) : base(couleur)
        {

        }

        //Choisir en premier la couleur avant de faire piger les cartes. Par la suite joue la carte et passe le tour du prochain joueur.
        public override void Jouer(Jeu jeu)
        {
            ChoisirCouleur();
            jeu.FairePigerProchain(4);
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return true; //Vue que c'est une carte Wild elle peut être jouée à tout moment
        }

        public override string GetCode()
        {
            return $"{couleur}+4";
        }
    }
}