using System;

namespace ProjetMMoMrBraux
{
    class Tournois
    {
        public void accepterTournoi(IAttaquantArme Joueur, IAttaquantArme Joueur2)
        {
            int turn = 1;
            while (Joueur.gethpv() > 0 && Joueur2.gethpv() > 0)
            {
                if (turn == 1)
                {
                    Console.WriteLine("Le joueur 2 attaque !");
                    Personnage cible = Joueur2 as Personnage;
                    int vieAvant = cible.gethpv();
                    Joueur.attaqueSpecialeArme(cible);               
                    int vieApres = cible.gethpv();
                    int degats = vieAvant - vieApres;
                    Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                    Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                    Console.ReadLine();
                    degats = 0;
                    turn++;
                }
                else if (turn == 2)
                {
                    Console.WriteLine("Le joueur 1 attaque !");
                    Personnage cible = Joueur as Personnage;
                    int vieAvant = cible.gethpv();
                    Joueur2.attaqueSpecialeArme(cible);
                    int vieApres = cible.gethpv();
                    int degats = vieAvant - vieApres;
                    Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                    Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                    Console.ReadLine();
                    degats = 0;
                    turn--;
                }
                try
                {
                    if (Joueur.gethpv() <= 0 || Joueur2.gethpv() <= 0)
                    {
                        if (Joueur.gethpv() <= 0)
                        {
                            Console.WriteLine("le Combatant suivant est mort ==> Combattant 1");
                        }
                        else
                            Console.WriteLine("le Combatant suivant est mort ==> Combattant 2");
                        throw new pdvSousZeroException();
                    }
                }
                catch (pdvSousZeroException)
                {
                    Console.WriteLine("Impossible de se battre, un des deux combattants est mort !!!");
                }
            }
        }
        public void accepterTournoi(IAttaquantMagie Joueur, IAttaquantMagie Joueur2)
        {
            int turn = 1;
            while (Joueur.gethpv() > 0 && Joueur2.gethpv() > 0)
            {
                if (turn == 1)
                {
                    Console.WriteLine("Le joueur 2 attaque !");
                    Personnage cible = Joueur2 as Personnage;
                    int vieAvant = cible.gethpv();
                    Joueur.attaqueSpecialeMagie(cible);
                    int vieApres = cible.gethpv();
                    int degats = vieAvant - vieApres;
                    Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                    Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                    Console.ReadLine();
                    degats = 0;
                    turn++;
                }
                else if (turn == 2)
                {
                    Console.WriteLine("Le joueur 1 attaque !");
                    Personnage cible = Joueur as Personnage;
                    int vieAvant = cible.gethpv();
                    Joueur2.attaqueSpecialeMagie(cible);
                    int vieApres = cible.gethpv();
                    int degats = vieAvant - vieApres;
                    Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                    Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                    Console.ReadLine();
                    degats = 0;
                    turn--;
                }
                try
                {
                    if (Joueur.gethpv() <= 0 || Joueur2.gethpv() <= 0)
                    {
                        if (Joueur.gethpv() <= 0)
                        {
                            Console.WriteLine("le Combatant suivant est mort ==> Combattant 1");
                        }
                        else
                            Console.WriteLine("le Combatant suivant est mort ==> Combattant 2");

                        throw new pdvSousZeroException();
                    }
                }
                catch (pdvSousZeroException)
                {
                    Console.WriteLine("Impossible de se battre, un des deux combattants est mort !!!");
                     
                }
            }
        }


    }
}
