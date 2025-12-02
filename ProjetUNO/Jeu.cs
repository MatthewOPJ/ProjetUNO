using System;

namespace ProjetUNO
{
    internal class Jeu
    {
        private List<Carte> paquetDeCartes;
        private List<Carte> cartesJouees;
        private List<Joueur> joueurs;

        private int tour;

        public Jeu()
        {
            CreerJoueurs();
            CreerPaquet();
        }

        // soit 1 ou -1
        private int sensDuTour;


        public void PasserTourProchain()
        {
            // entracte
        }

        public void FairePigerProchain(int nombreCartesAPiger)
        {
            // entracte
        }

        public void Jouer()
        {
            DistribuerCartes();
            
            // boucle de jeu
        }

        public void CreerJoueurs()
        {
            
        }

        public void InverserTour()
        {
            // entracte
        }

        //Nous permet d'ajouter une carte sur le top de la pile de jeu.
        public void JouerCarte(Carte carte)
        {
            
        }

        private void CreerPaquet()
        {
            
        }

        private void DistribuerCartes()
        {
            
        }

        // autres fonctions plus petites
    }
}