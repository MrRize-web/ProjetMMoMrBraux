using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    abstract class Personnage
    {
        protected Random Statrandom = new Random();
        protected string nom { get;  set; }
        protected int hpv { get;  set; }
        protected int agilite { get;  set; }
        protected int force { get;  set; }
        protected int mana { get; set; }
        protected Sac[] mesSac { get;  set; }
  
        public Personnage()
        {
            int nms = getNbSacMax();
            this.mesSac = new Sac[nms];
            for (int i = 0; i < nms; i++)
            {
             
                mesSac[i] = new Sac();
            }
        }

        public void retirerItem(int sac, Objets nomObjet)
        {
            mesSac[sac].retirerItem(nomObjet);
        }

        public void ajouterItem(int sac, Objets nomObjet)
        {
   
            mesSac[sac].ajouterItem(nomObjet);
        }
        public void afficherSac(int sac)
        {
            mesSac[sac].afficher();
        }
        public abstract void Displays();
        public abstract int getNbSacMax();

        public void accepterTournoiArme(IAttaquantArme un, IAttaquantArme deux)
        {

        }
        public void accepterTournoiMagie(IAttaquantArme un, IAttaquantArme deux)
        {

        }
        //  public abstract int getMaxForce();

    }

}
