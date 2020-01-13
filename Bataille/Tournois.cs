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
                    Personnage cible = Joueur2 as Personnage;
                    Joueur.attaqueSpecialeArme(cible);
                    turn++;
                }
                else if (turn == 2)
                {
                    Personnage cible = Joueur as Personnage;
                    Joueur2.attaqueSpecialeArme(cible);
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
                    Personnage cible = Joueur2 as Personnage;
                    Joueur.attaqueSpecialeMagie(cible);
                    turn++;
                }
                else if (turn == 2)
                {
                    Personnage cible = Joueur as Personnage;
                    Joueur2.attaqueSpecialeMagie(cible);
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
