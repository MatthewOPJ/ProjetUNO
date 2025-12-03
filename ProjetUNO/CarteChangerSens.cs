using System;

namespace ProjetUNO
{
    internal class CarteChangerSens : Carte
    {
        public CarteChangerSens(char couleur) : base(couleur)
        {

        }

        public override void Jouer(ref Jeu jeu)
        {
            jeu.InverserTour();
            jeu.JouerCarte(this);
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur || topPile.GetType() == typeof(CarteChangerSens);    
        }

        public override string GetCode()
        {
            return $"{couleur}CDS";
        }
    }
}