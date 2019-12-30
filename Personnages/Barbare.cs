using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Barbare : Personnage, IAttaquantArme
    {
        public static int hpvM = 30;
        public static int agiliteM = 15;
        public static int forceM = 20;
        private Arme armePortee;
        private Team afficherteam;
        public override int getNbSacMax() { return 5; }

        public Barbare(string name) : base(name)
        {
            this.hpv = Statrandom.Next(1,hpvM);
            this.agilite = Statrandom.Next(1, agiliteM);
            this.force = Statrandom.Next(1, forceM);
        }

        public override void Displays()
        {

            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("|--------Statistique----------|");
            Console.WriteLine(" -->  Classe   : Barbare");
            Console.WriteLine(" -->  HP       : " + this.hpv);
            Console.WriteLine(" -->  Agilité  : " + this.agilite);
            Console.WriteLine(" -->  Force    : " + this.force);
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        public override void afficherTeam()
        {
            Console.WriteLine("|--------Equipe----------|");
            Team equipe1 = new Team();
            equipe1.afficher();

        }

        /*   public void attaque(Barbare deux)
           {
               Random rand = new Random();
               int degats = (rand.Next(10) + forceM) / 3;
               Console.WriteLine(deux.nom + "prend" + degats + "Pdv");
               deux.SethpvM((deux.GetHpvM) - degats);
           }*/




    /*    public override int AttaqueSpeciale(Personnage p)
        {
            Random rand = new Random();
            int degats = (rand.Next(10) + forceM) / 3;
            Console.WriteLine(nom + "prend" + degats + "Pdv");
            int dmg = p.gethpv();
            dmg -= degats;
            p.SethpvM(dmg);
            throw new NotImplementedException();
        }*/
        public void attaqueSpecialeArme(Personnage persoADemonter)
        {
            persoADemonter.sethpv(persoADemonter.gethpv() - armePortee.getPuissance());
        }
        public string getArme()
        {
            return "Type: " + armePortee.getType() + ", Puissance: " + armePortee.getPuissance();
        }
      /*  public override int AttaqueArme(Arme arme)
        {
            throw new NotImplementedException();
        }*/
    }
}
