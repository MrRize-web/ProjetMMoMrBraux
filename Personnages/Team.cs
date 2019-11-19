using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class Team
    {
        protected SortedSet<Personnage> team;
        protected string nom;
        public string Nom { get; set; }
        public Team(string nom)
        {
            Console.WriteLine();
            team = new SortedSet<Personnage>();
            Nom = this.nom;
        }
        public void add(Personnage p)
        {
            team.Add(p);
        }
        public void afficherTeam()
        {
            Console.WriteLine("L'équipe est composé " + this.Nom);

        }
    }
}
