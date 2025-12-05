using System;

namespace ProjetUNO
{
    abstract internal class Carte
    {
        protected internal char couleur;

        protected Carte(char couleur)
        {
            this.couleur = couleur;
        }

        public abstract void Jouer(Jeu jeu);

        //Fonction qui verifie si la carte peut etre jouée
        public abstract bool PeutJouer(Carte topPile);

        //Aller chercher le code unique de la carte
        public abstract string GetCode();
    }
}