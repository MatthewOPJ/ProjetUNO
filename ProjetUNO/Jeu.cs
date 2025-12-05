using System;
using System.Runtime.InteropServices;

namespace ProjetUNO
{
    internal class Jeu
    {
        private List<Carte> paquetDeCartes = new List<Carte>();
        private List<Carte> cartesJouees = new List<Carte>();
        private List<Joueur> joueurs = new List<Joueur>();

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
            tour = GetProchainTour();
            Console.WriteLine($" Le tour de {joueurs[tour].nom} est bloqué. Appuyer sur une touche pour continuer");
            Console.ReadKey();
        }

        public void FairePigerProchain(int nombreCartesAPiger)
        {
            int prochainTour = GetProchainTour();

            for (int i = 0; i < nombreCartesAPiger; i++) 
            {
                if (paquetDeCartes.Count == 0) 
                {
                    Carte carte = cartesJouees.Last();

                    cartesJouees.RemoveAt(cartesJouees.Count - 1);
                    paquetDeCartes = cartesJouees;
                    cartesJouees.Clear();

                    MelangerPaquet();
                }

                joueurs[prochainTour].Piger(paquetDeCartes.Last());
                paquetDeCartes.RemoveAt(paquetDeCartes.Count - 1);
            }
        }

        public void Jouer()
        {
            MelangerPaquet();
            DistribuerCartes();
            
            sensDuTour = 1;
            tour = 0;

            while (true)
            {
                // afficher le nombre de cartes de chaque joueur
                for(int i = 0; i < joueurs.Count; i++)
                {
                    int nombreCartes = joueurs[i].GetNombreDeCartes();

                    Console.Write($"{joueurs[i].nom} possède {nombreCartes} cartes");

                    if(nombreCartes == 1) Console.Write(" (UNO!)");

                    Console.WriteLine();
                }

                Console.WriteLine($"C'est le tour de {joueurs[tour].nom}\n");

                Console.WriteLine($"La carte au dessus de la pile est {cartesJouees.Last().GetCode()}\n");

                if (!joueurs[tour].Peutjouer(cartesJouees.Last()))
                {
                    joueurs[tour].AfficherCartes();

                    Carte cartePigee = paquetDeCartes.Last();
                    paquetDeCartes.RemoveAt(paquetDeCartes.Count - 1);

                    Console.WriteLine($"Vous ne pouvez malheureusement pas jouer de carte, vous pigez {cartePigee.GetCode()}");

                    if (cartePigee.PeutJouer(cartesJouees.Last()))
                    {
                        Console.WriteLine("Vous êtes obligé(e) de jouez la carte pigée");
                        cartePigee.Jouer(this);
                        joueurs[tour].Rejouer(this, cartePigee);
                    }
                    else
                    {
                        Console.WriteLine("Vous ne pouvez pas jouer la carte pigée, vous passez votre tour");
                        joueurs[tour].Piger(cartePigee);
                    }
                }
                else
                {
                    joueurs[tour].Jouer(this, cartesJouees.Last());

                    if(joueurs[tour].GetNombreDeCartes() == 0) break;
                }

                tour = GetProchainTour();

                Console.Clear();
            }
        }

        private int GetProchainTour()
        {
            int nouveauTour = tour + sensDuTour;

            if (nouveauTour < 0) nouveauTour = joueurs.Count - 1;
            else nouveauTour %= joueurs.Count;

            return nouveauTour;
        }

        private void MelangerPaquet()
        {
            Random rand = new Random();
                    
            for(int j = 0; j < paquetDeCartes.Count; j++)
            {
                int swap = rand.Next(j, paquetDeCartes.Count);

                Carte temp = paquetDeCartes[j];
                paquetDeCartes[j] = paquetDeCartes[swap];
                paquetDeCartes[swap] = temp;
            }
        }

        public void CreerJoueurs()
        {
            int nombreJoueurs = 3;

            string nomJoueurs;

            Console.WriteLine("Entrer le nom des joueurs: ");

            for (int i = 0; i < nombreJoueurs; i++)
            {
                Console.Write($"Entrez le nom du joueur {i + 1}: ");
                nomJoueurs = Console.ReadLine();
                
                if (String.IsNullOrEmpty(nomJoueurs))
                {
                    Console.WriteLine("Veuillez rentrer un nom...");
                    i--;
                    continue;
                }
                joueurs.Add(new Joueur(nomJoueurs));
            }
        }

        public void InverserTour()
        {
            sensDuTour = -sensDuTour;
            Console.WriteLine("Le tour est invers�. Appuyer sur une touche pour continuer");
            Console.ReadKey();
        }

        //Nous permet d'ajouter une carte sur le top de la pile de jeu.
        public void JouerCarte(Carte carte)
        {
            cartesJouees.Add(carte);
        }

        private void CreerPaquet()
        {
            for (int i = 0; i < 4; i++)
            {
                paquetDeCartes.Add(new CarteWild('W'));
                paquetDeCartes.Add(new CartePlus4('W'));
            }

            const string couleurs = "BJRV";

            foreach (var couleur in couleurs)
            {
                paquetDeCartes.Add(new CartePlus2(couleur));
                paquetDeCartes.Add(new CartePlus2(couleur));

                paquetDeCartes.Add(new CarteChangerSens(couleur));
                paquetDeCartes.Add(new CarteChangerSens(couleur));

                paquetDeCartes.Add(new CartePasserTour(couleur));
                paquetDeCartes.Add(new CartePasserTour(couleur));

                paquetDeCartes.Add(new CarteChiffre(couleur, 0));

                for (int i = 1; i <= 9; i++)
                {
                    paquetDeCartes.Add(new CarteChiffre(couleur, i));
                    paquetDeCartes.Add(new CarteChiffre(couleur, i));
                }
            }
        }

        private void DistribuerCartes()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < joueurs.Count; j++)
                {
                    joueurs[j].Piger(paquetDeCartes.Last());
                    paquetDeCartes.RemoveAt(paquetDeCartes.Count - 1);
                }
            }

            // tant que topPile est pas une CarteChiffre
            Carte topPile = new CarteWild('W');

            while(topPile.GetType() != typeof(CarteChiffre))
            {
                topPile = paquetDeCartes.Last();
                cartesJouees.Add(topPile);
                paquetDeCartes.RemoveAt(paquetDeCartes.Count - 1);
            }
        }
    }
}
