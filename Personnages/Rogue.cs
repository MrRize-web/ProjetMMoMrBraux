using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Rogue : Personnage, IAttaquantArme
    {
        public static int hpvM = 20;
        public static int agiliteM = 20;
        public static int forceM = 15;
        public override int getNbSacMax() { return 3; }
        public override void Displays()
        {
            Console.WriteLine("|--------Statistique----------|");
            Console.WriteLine(" -->  Classe  : Rogue");
            Console.WriteLine(" -->  HP      : " + this.hpv);
            Console.WriteLine(" -->  Agilité : " + this.agilite);
            Console.WriteLine(" -->  Force   : " + this.force);
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        public Rogue(/*string name*/)
        {
            //this.nom = name;
            this.hpv = Statrandom.Next(1, hpvM);
            this.agilite = Statrandom.Next(1, agiliteM);
            this.force = Statrandom.Next(1, forceM);
        }
        public override void afficherTeam()
        {
            Console.WriteLine("|--------Equipe----------|");
        }

     public  void AttaqueSpeciale(Personnage personnage)
        {
            Random rand = new Random();
            int degats = (rand.Next(10) + agiliteM) / 3;
            Console.WriteLine(nom + "prend" + degats + "Pdv");
            int dmg = personnage.GetHpvM(hpv);
            dmg -= degats;
            personnage.SethpvM(dmg);
        }
       public void AttaqueArme(Arme arme)
        {
            
        }
    }

}
