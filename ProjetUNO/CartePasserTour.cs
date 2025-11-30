using System;

namespace ProjetUNO
{
    internal class CartePasserTour : Carte
    {
        public override void Jouer(ref Jeu jeu)
        {
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CartePasserTour);

        }

        public override void Afficher()
        {
            Console.Write(couleur);
        }
    }
}