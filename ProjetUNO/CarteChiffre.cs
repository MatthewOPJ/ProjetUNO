using System;

namespace ProjetUNO
{
    internal class CarteChiffre : Carte
    {
        private int chiffre { get; };

        public override void Jouer(ref Jeu jeu){

        }

        public override bool PeutJouer(Carte topPile){

        }

        // pas sur si cete fonction là va marcher comme je le pense...
        // sinon on changera
        public override bool PeutJouer(CarteChiffre topPile){

        }

        public override void Afficher(){

        }
    }
}