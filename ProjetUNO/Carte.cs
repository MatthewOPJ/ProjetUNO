using System;

namespace ProjetUNO
{
    abstract internal class Carte
    {
        // enum mais on a pas vu les enums
        // plus lisible comme ca
        public static const int WILD = 0;
        public static const int ROUGE = 1;
        public static const int BLEU = 2;
        public static const int JAUNE = 3;
        public static const int VERT = 4;

        private int couleur { get; };

        abstract void Jouer(ref Jeu jeu);

        abstract bool PeutJouer(Carte topPile);

        abstract void Afficher();
    }
}