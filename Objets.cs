using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Objets
    {
        private string nom;
        private int poids;

        
        public Objets(string nom, int poids)
        {
            Random rand = new Random();
            poids = rand.Next(poids / 2, poids);
            this.nom = nom;
            this.poids = poids;            
        }
        public void afficherObjets()
        {
            Console.WriteLine("Nom : " + this.nom + " avec pour poid : " + this.poids+"pods");
        }

    }
}
