using System;

namespace ProjetUNO
{
    internal class CarteChiffre : Carte
    {
        public int chiffre { get; private set; }

        public CarteChiffre(char couleur, int chiffre) : base(couleur)
        {
            this.chiffre = chiffre;
        }

        public override void Jouer(Jeu jeu)
        {
            jeu.JouerCarte(this);
        }

        public override bool PeutJouer(Carte topPile)
        {
            if (topPile.GetType() == typeof(CarteChiffre))
            {
                return ((CarteChiffre)topPile).chiffre == chiffre || topPile.couleur == couleur; //vérification du chiffre ou de la couleur
            }
            return topPile.couleur == couleur;
        }

        public override string GetCode()
        {
            return $"{couleur}{chiffre}";
        }
    }
}