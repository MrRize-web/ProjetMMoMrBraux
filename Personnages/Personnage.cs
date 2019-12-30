using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    abstract class Personnage : IComparable<Personnage>
    {
        protected Random Statrandom = new Random();
        protected string nom { get; set; }
        protected int hpv { get; set; }
        protected int agilite { get; set; }
        protected int force { get; set; }
        protected int mana { get; set; }
        protected Sac[] mesSac { get; set; }

        public Personnage(string name)
        {
            this.nom = name;
            int nms = getNbSacMax();
            this.mesSac = new Sac[nms];
            for (int i = 0; i < nms; i++)
            {
                mesSac[i] = new Sac();
            }
        }

        public void SethpvM(int deg)
        {
            this.hpv = deg;
        }

        public int gethpv()
        {
            return this.hpv;
        }

        public void sethpv(int vie)
        {
            this.hpv = vie;
        }
        public string getName()
        {
            return this.nom;
        }
 
        public int CompareTo(Personnage p)
        {
            int result = string.Compare(this.getName(), p.getName());
            return result;
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

        public bool countObjets(int sac)
        {
            if (mesSac[sac].count() == true)
            {
                return true;
            }
            return false;
        }
        public abstract void afficherTeam();
        public abstract void Displays();
        public abstract int getNbSacMax();
        public abstract void afficherArme();
    }

}
