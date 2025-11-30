using System;

namespace ProjetUNO
{
    internal class CartePlus4 : Carte
    {
        public override void Jouer(ref Jeu jeu)
        {
            jeu.FairePigerProchain(4);
        }

        public override bool PeutJouer(Carte topPile){
            throw new NotImplementedException();
        }

        public override void Afficher(){

        }
    }
}