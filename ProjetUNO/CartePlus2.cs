using System;

namespace ProjetUNO
{
    internal class CartePlus2 : Carte
    {
        public override void Jouer(ref Jeu jeu){

        }

        public override bool PeutJouer(Carte topPile){
            throw new NotImplementedException();
        }

        public override void Afficher(){

        }
    }
}