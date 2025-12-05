using System;

namespace ProjetUNO
{
    internal class CarteChangerSens : Carte
    {
        public CarteChangerSens(char couleur) : base(couleur)
        {

        }

        //La carte inverse le sens du jeu et ensuite se joue normalement
        public override void Jouer(Jeu jeu)
        {
            jeu.InverserTour();
            jeu.JouerCarte(this);
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CarteChangerSens);//vérifie si la couleur est la même ou si la carte du dessus est aussi une carte Changer Sens
        }

        public override string GetCode()
        {
            return $"{couleur}CDS";
        }
    }
}