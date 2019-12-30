using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ProjetMMoMrBraux
{
    class Rogue : Personnage, IAttaquantArme
    {
        public static int hpvM = 20;
        public static int agiliteM = 20;
        public static int forceM = 15;
        private Arme armePortee;
        public override int getNbSacMax() { return 3; }
        public override void Displays()
        {
            Console.WriteLine("|--------Statistique----------|");
            Console.WriteLine(" -->  Classe  : Rogue");
            Console.WriteLine(" -->  HP      : " + this.hpv);
            Console.WriteLine(" -->  Agilité : " + this.agilite);
            Console.WriteLine(" -->  Force   : " + this.force);
            Console.WriteLine(" -->  Arme   : " + this.armePortee);
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        public override void afficherTeam()
        {
            Console.WriteLine("|--------Equipe----------|");
        }
        public override void afficherArme()
        {
            Console.WriteLine("|--------Arme-----------------|");
            Console.WriteLine("|--Nom : " + this.armePortee + "|");
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        public Rogue(string name) : base(name)
        {
            this.hpv = Statrandom.Next(1, hpvM);
            this.agilite = Statrandom.Next(1, agiliteM);
            this.force = Statrandom.Next(1, forceM);
            this.armePortee = new Arme();
        }
   
        public void attaqueSpecialeArme(Personnage persoAtuer)
        {
            persoAtuer.sethpv(persoAtuer.gethpv() - armePortee.getPuissance());
        }
        public string getArme()
        {
            return "Type: " + armePortee.getType() + ", Puissance: " + armePortee.getPuissance();
        }
      /*  public  void AttaqueSpeciale(Personnage personnage)
        {
            Random rand = new Random();
            int degats = (rand.Next(10) + agiliteM) / 3;
            Console.WriteLine(nom + "prend" + degats + "Pdv");
            int dmg = personnage.GetHpvM(hpv);
            dmg -= degats;
            personnage.SethpvM(dmg);
        }*/
    /*   public void AttaqueArme(Arme arme)
        {
            
        }*/
    }

}
