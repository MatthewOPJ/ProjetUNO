using System;

namespace ProjetUNO
{
    internal class CarteChiffre : Carte
    {
        private int chiffre { get; }

        public override void Jouer(ref Jeu jeu){

        }

        public override bool PeutJouer(Carte topPile)
        {
            throw new NotImplementedException();
        }

        // pas sur si cete fonction là va marcher comme je le pense...
        // sinon on changera
        public bool PeutJouer(CarteChiffre topPile){
            throw new NotImplementedException();
        }

        public override void Afficher(){

        }
    }
}