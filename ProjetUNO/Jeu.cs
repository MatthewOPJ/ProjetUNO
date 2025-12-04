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
            int nombreJoueurs = 3;

            string nomJoueurs;

            Console.WriteLine("Entrer le nom des joueurs: ");

            for (int i = 0; i < nombreJoueurs; i++)
            {
                Console.WriteLine($"Entrez le nom du joueur {i + 1}");
                nomJoueurs = Console.ReadLine();
                
                if (String.IsNullOrEmpty(nomJoueurs))
                {

                }
            }
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