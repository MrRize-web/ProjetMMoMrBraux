using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Objets
    {
        private string nom;
        //private string poids { get; set; }


        public Objets(string nom/*, int poids*/)
        {
            this.nom = nom;
         //   Random rand = new Random();
         //   poids = rand.Next(poids / 2, poids);
         //   this.poids = poids;
        }
        public void afficherObjets()
        {
            Console.WriteLine("Nom : " + this.nom /*+ " / poid : " + this.poids*/);
        }

    }
}
