using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Sac
    {

         Stack<Objets> iventaireSac = new Stack<Objets>(4);
          public Sac()
          {
            iventaireSac = new Stack<Objets>();           
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
        public bool count()
        {
          
            if (iventaireSac.Count() >= 1)
            {
                return false;
            } else
            {
                return true;
            }
            
        }
    }
}
