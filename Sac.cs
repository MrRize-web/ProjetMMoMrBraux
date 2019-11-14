using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Sac
    {
       
        Stack<Objets> iventaireSac = new Stack<Objets>();
          public Sac()
          {
           
            iventaireSac = new Stack<Objets>(4);
           
          }
     
        public void ajouterItem(Objets objet)
        {
            iventaireSac.Push(objet);
        }
        public void retirerItem(Objets objet)
        {
            iventaireSac.Pop();
        }
        public void afficher()
        {
            foreach (Objets nom in iventaireSac)
            {
                nom.afficherObjets();
            }
        
        }

    }
}
