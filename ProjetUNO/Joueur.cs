using System;

namespace ProjetUNO
{
    internal class Joueur
    {
        private List<Carte> paquetDeCartes;

        private string nom { get; }


        // pas nécessairement besoin de topPile si on a deja accès au jeu...
        public void Jouer(ref Jeu jeu, Carte topPile)
        {
            
        }

        public void Piger(Carte carte)
        {
            paquetDeCartes.Add(carte);
        }
        public void AfficherCartes()
        {
            Console.Write("Vos cartes sont: ");

            foreach (Carte carte in paquetDeCartes)
            {
                carte.Afficher();
                Console.Write(", ");
            }
        }
        // autres fonctions plus petites
        // demander input par exemple
    }
}