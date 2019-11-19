using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Barbare : Personnage
    {
        public static int hpvM = 30;
        public static int agiliteM = 15;
        public static int forceM = 20;

        public override int getNbSacMax() { return 5; }
       // public override int getMaxForce() { return this.force; }

        public Barbare(/*string name*/)
        {
            //this.nom = name;
            this.hpv = Statrandom.Next(1,hpvM);
            this.agilite = Statrandom.Next(1, agiliteM);
            this.force = Statrandom.Next(1, forceM);

        }

        public override void Displays()
        {

            //  Console.WriteLine("Nom : " + this.nom);
            Console.WriteLine("|--------Statistique----------|");
            Console.WriteLine(" -->  Classe   : Barbare");
            Console.WriteLine(" -->  HP       : " + this.hpv);
            Console.WriteLine(" -->  Agilité  : " + this.agilite);
            Console.WriteLine(" -->  Force    : " + this.force);
            Console.WriteLine("|-----------------------------|" + "\n");
        }
        /*
        public void attaque(Barbare deux)
        {
            int degats = (Random.Next(10) + forceM) / 3;
            Console.WriteLine(deux.nom + "prend" + degats + "Pdv");
            deux.SethpvM((deux.GetHpvM) - degats);
        }*/
        public override void afficherTeam()
        {
            Console.WriteLine("|--------Equipe----------|");
        }
    }
}
