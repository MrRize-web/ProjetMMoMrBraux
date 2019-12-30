using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Healer : Personnage, IAttaquantMagie
    {
        public static int hpvM = 15;
        public static int agiliteM = 15;
        public static int forceM = 15;
        private Magie sortAcqui;
        public override int getNbSacMax() { return 2; }

        public override  void Displays()
        {
            Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("|--------Statistique----------|");
            Console.WriteLine(" -->  Classe   : Healer");
            Console.WriteLine(" -->  HP       : " + this.hpv);
            Console.WriteLine(" -->  Agilité  : " + this.agilite);
            Console.WriteLine(" -->  Force    : " + this.force);
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        public Healer(string name) : base(name)
        {
            this.nom = name;
            this.hpv = Statrandom.Next(1, hpvM);
            this.agilite = Statrandom.Next(1, agiliteM);
            this.force = Statrandom.Next(1, forceM);

        }
      /*  public void attaque(Healer deux)
        {
            Random rand = new Random();
            int degats = (rand.Next(10) + forceM) / 3;
            Console.WriteLine(deux.nom + "prend" + degats + "Pdv");
            deux.SethpvM((deux.GetHpvM) - degats);
        }*/
        public override void afficherTeam()
        {
            Console.WriteLine("|--------Equipe----------|");
            
         /*   Team equipe1 = new Team();
            equipe1.afficher();*/
        }

       public void AttaqueMagie(Magie magie)
        {
  
        }

        public void attaqueSpecialeMagie(Personnage persoADemonter)
        {
            persoADemonter.sethpv(persoADemonter.gethpv() - sortAcqui.getPuissance());
        }
        public string getSort()
        {
            return "Type: " + sortAcqui.getNom() + ", Puissance: " + sortAcqui.getPuissance();
        }
      /*  public void AttaqueSpeciale(Personnage personnage)
        {
            Random rand = new Random();
            int degats = (rand.Next(10) + forceM) / 3;
            Console.WriteLine(nom + "prend" + degats + "Pdv");
            int dmg = personnage.GetHpvM(hpv);
            dmg -= degats;
            personnage.SethpvM(dmg);
        }*/
    }
}
