using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Rogue : Personnage
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
    }

}
