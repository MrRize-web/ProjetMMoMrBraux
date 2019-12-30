using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Arme
    {
        private string type;
        private int puissance;

        public Arme()
        {
            this.type = "Hache";
            this.puissance = 30;
            this.type = "Epée";
            this.puissance = 20;
            this.type = "Dague";
            this.puissance = 10;
            this.type = "Baton Feu";
            this.puissance = 25;
            this.type = "Baton Foret";
            this.puissance = 5;
        }

        public string getType()
        {
            return this.type;
        }
        public int getPuissance()
        {
            return this.puissance;
        }
    }
}
