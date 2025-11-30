using System;

namespace ProjetUNO
{
    internal class CarteChangerSens : Carte
    {
        public override void Jouer(ref Jeu jeu)
        {
            jeu.InverserTour();
        }

        public override bool PeutJouer(Carte topPile){
            throw new NotImplementedException();
        }

        public override void Afficher(){

        }
    }
}