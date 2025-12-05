using System;

namespace ProjetUNO
{
    internal class CartePasserTour : Carte
    {
        public CartePasserTour(char couleur) : base(couleur)
        {

        }

        public override void Jouer(Jeu jeu)
        {
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CartePasserTour);

        }

        public override string GetCode()
        {
            return $"{couleur}PT";
        }
    }
}