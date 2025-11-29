using System;

namespace ProjetUNO
{
    internal class CarteChangerSens : Carte
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