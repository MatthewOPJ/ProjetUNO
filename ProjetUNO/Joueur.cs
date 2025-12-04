using System;

namespace ProjetUNO
{
    internal class Joueur
    {
        private List<Carte> paquetDeCartes;

        public string nom;

        public Joueur(string nom)
        {
            this.nom = nom;
        }

        // on sait que le joueur peut jouer
        public void Jouer(Jeu jeu, Carte topPile)
        {
            AfficherCartes();

            string reponse;

            // initialisée pour pas que le compilateur chiale
            Carte carteAJouer = new CarteWild('W');

            Console.WriteLine("Quel carte voulez-vous jouer? (Entrez son code)");

            bool verifier = true;

            do
            {
                reponse = Console.ReadLine();

                foreach (Carte carte in paquetDeCartes)
                {
                    if(carte.GetCode() == reponse)
                    {
                        if (carte.PeutJouer(topPile))
                        {
                            carteAJouer = carte;
                            verifier = false;
                        }
                        else
                        {
                            Console.WriteLine("Cette carte ne peut pas être jouée");
                        }
                        break;
                    }
                }
                Console.WriteLine("Vous n'avez pas cette carte dans votre main.");

            } while (verifier);

            // jouer la carte

            Console.WriteLine($"Vous jouez la carte {carteAJouer.GetCode()}");

            paquetDeCartes.Remove(carteAJouer);
            carteAJouer.Jouer(jeu);

            Rejouer(jeu, carteAJouer);
        }

        public void Rejouer(Jeu jeu, Carte topPile)
        {
            if (!VeuxRejouer(topPile)) return;

            string reponse;

            AfficherCartes();

            // initialisée pour pas que le compilateur chiale
            Carte carteAJouer = new CarteWild('W');

            Console.WriteLine("Quel carte voulez-vous jouer? (Entrez son code)");

            do
            {
                reponse = Console.ReadLine();

                if (PeutRejouer(carteAJouer))
                {
                    Console.WriteLine("Cette carte ne peut pas être jouée");
                }
                else
                {
                    break;
                }
                // pas de deuxième message d'erreur, malheureusement
                //Console.WriteLine("Vous n'avez pas cette carte dans votre main.");

            } while (true);

            // jouer la carte

            Console.WriteLine($"Vous jouez la carte {carteAJouer.GetCode()}");

            paquetDeCartes.Remove(carteAJouer);
            carteAJouer.Jouer(jeu);

            Rejouer(jeu, carteAJouer);
        }

        private bool PeutRejouer(Carte carteARejouer)
        {
            if (carteARejouer.GetType() != typeof(CarteChiffre)) return false;

            foreach (Carte carte in paquetDeCartes)
            {
                if (carte.GetType() == typeof(CarteChiffre))
                {
                    if (((CarteChiffre)carte).chiffre == ((CarteChiffre)carteARejouer).chiffre)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Peutjouer(Carte topPile)
        {
            foreach (Carte carte in paquetDeCartes)
            {
                if (carte.PeutJouer(topPile))
                {
                    return true;
                }
            }
            return false;
        }

        private bool VeuxRejouer(Carte topPile)
        {
            if (!PeutRejouer(topPile)) return false;

            string reponse;

            while (true)
            {
                Console.WriteLine("Voulez vous jouer une carte du même chiffre que la carte précédente ? O/N: ");
                reponse = Console.ReadLine().ToUpper();

                if (reponse == "N")
                {
                    return true;
                }
                else if (reponse == "O")
                {
                    break;
                }
                Console.WriteLine("Veuillez entrez 'O' ou 'N' (Oui ou Non)");
            }
            return false;
        }

        public void Piger(Carte carte)
        {
            paquetDeCartes.Add(carte);
        }

        public int GetNombreDeCartes()
        {
            return paquetDeCartes.Count;
        }

        public void AfficherCartes()
        {
            Console.Write("Vos cartes sont: ");

            foreach (Carte carte in paquetDeCartes)
            {
                Console.Write(carte.GetCode());
                Console.Write(", ");
            }
        }
        // autres fonctions plus petites
        // demander input par exemple
    }
}