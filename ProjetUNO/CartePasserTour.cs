using System;

namespace ProjetUNO
{
    internal class CartePasserTour : Carte
    {
        public CartePasserTour(char couleur) : base(couleur)
        {

        }

        //La carte se joue d'abords et ensuite le prochain joueur passe son tour
        public override void Jouer(Jeu jeu)
        {
            jeu.JouerCarte(this);
            jeu.PasserTourProchain();
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CartePasserTour); //vérifie si la couleur est la même ou si la carte du dessus est aussi une carte Passer Tour

        }

        public override string GetCode()
        {
            return $"{couleur}PT";
        }
    }
}