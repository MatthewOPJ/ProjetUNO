using System;

namespace ProjetUNO
{
    abstract internal class Carte
    {
        // enum mais on a pas vu les enums
        // plus lisible comme ca
        //public const int WILD = 0;
        //public const int ROUGE = 1;
        //public const int BLEU = 2;
        //public const int JAUNE = 3;
        //public const int VERT = 4;

        protected internal char couleur;

        protected Carte(char couleur)
        {
            this.couleur = couleur;
        }

        public abstract void Jouer(ref Jeu jeu);

        // peut etre as besoin d'être abstract vu que toutes les cartes partagent le meme code ici
        public abstract bool PeutJouer(Carte topPile);

        public abstract string GetCode();
    }
}