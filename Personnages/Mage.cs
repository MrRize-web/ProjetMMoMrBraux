using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Mage : Personnage, IAttaquantMagie
    {
     
        public static int hpvM = 20;
        public static int manaM = 20;
        public static int agiliteM = 15;
        public static int forceM = 15;
        public override int getNbSacMax() { return 2; }

        public override void Displays()
        {
            Console.WriteLine("|--------Statistique----------|");
            Console.WriteLine(" -->  Classe   : Mage");
            Console.WriteLine(" -->  HP       : " + this.hpv);
            Console.WriteLine(" -->  Mana     : " + this.mana);
            Console.WriteLine(" -->  Agilité  : " + this.agilite);
            Console.WriteLine(" -->  Force    : " + this.force);
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        public Mage(/*string name*/)
        {
            //this.nom = name;
            this.hpv = Statrandom.Next(1, hpvM);
            this.mana = Statrandom.Next(1, manaM);
            this.agilite = Statrandom.Next(1, agiliteM);
            this.force = Statrandom.Next(1, forceM);

        }
        public override void afficherTeam()
        {
            Console.WriteLine("|--------Equipe----------|");
        }

      public  void AttaqueMagie(Magie magie)
        {

        }

       public void AttaqueSpeciale(Personnage personnage)
        {
            Random rand = new Random();
            int degats = (rand.Next(10) + manaM) / 3;
            Console.WriteLine(nom + "prend" + degats + "Pdv");
            int dmg = personnage.GetHpvM(hpv);
            dmg -= degats;
            personnage.SethpvM(dmg);
        }
    }
}
