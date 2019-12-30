using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Magie
    {
        private string nom;
        private int puissance;

        public Magie()
        {
            this.nom = "Boule de feu";
            this.puissance = 20;
            this.nom = "Boule de Glace";
            this.puissance = 20;
            this.nom = "Armageddon";
            this.puissance = 1000;
        }
        public string getNom()
        {
            return this.nom;
        }
        public int getPuissance()
        {
            return this.puissance;
        }
    }
}
