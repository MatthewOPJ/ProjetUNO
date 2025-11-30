using System;

namespace ProjetUNO
{
    internal class CarteChiffre : Carte
    {
        private int chiffre;

        public override void Jouer(ref Jeu jeu)
        {
            jeu.JouerCarte(this);
        }

        public override bool PeutJouer(Carte topPile)
        {
            return topPile.couleur == couleur;
        }

        // pas sur si cete fonction là va marcher comme je le pense...
        // sinon on changera
        public bool PeutJouer(CarteChiffre topPile)
        {
            return topPile.chiffre == chiffre || topPile.couleur == couleur;
        }

        public override void Afficher()
        {
            Console.Write($"{couleur}{chiffre}");
        }
    }
}