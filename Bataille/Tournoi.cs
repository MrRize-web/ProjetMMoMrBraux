using System;
using System.Collections.Generic;
using System.Text;


namespace ProjetMMoMrBraux.Bataille
{
    class Tournoi
    {
        Personnage[] tabJoueur = new Personnage[2];
        public Tournoi(Personnage joueur1, Personnage joueur2)
        {
            tabJoueur[0] = joueur1;
            tabJoueur[1] = joueur2;
        }
        public void accepterTournoiArme()
        {

            int jouer = 0;
            bool fin = false;
            while (fin == false)
            {
                try
                {
                    if (tabJoueur[jouer].gethpv() > 0)
                    {

                        if (jouer == 0)
                        {

                            Personnage cible = tabJoueur[1];
                            if (tabJoueur[jouer].getClasses() == "Guerrier")
                            {
                                Console.WriteLine("Le joueur 1 attaque !");
                                int vieAvant = cible.gethpv();
                                ((Barbare)tabJoueur[jouer]).attaqueSpecialeArme(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            else if (tabJoueur[jouer].getClasses() == "Rogue")
                            {
                                Console.WriteLine("Le joueur 1 attaque !");
                                int vieAvant = cible.gethpv();
                                ((Rogue)tabJoueur[jouer]).attaqueSpecialeArme(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            if (cible.gethpv() <= 0)
                            {
                                Console.WriteLine("Le Joueur 1 a gagné !");
                                fin = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                jouer++;

                            }



                        }
                        else if (jouer == 1)
                        {
                            Personnage cible = tabJoueur[0];

                            if (tabJoueur[jouer].getClasses() == "Barbare")
                            {
                                int vieAvant = cible.gethpv();
                                ((Barbare)tabJoueur[jouer]).attaqueSpecialeArme(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 1 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 1 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;

                            }
                            else if (tabJoueur[jouer].getClasses() == "Rogue")
                            {
                                int vieAvant = cible.gethpv();
                                ((Rogue)tabJoueur[jouer]).attaqueSpecialeArme(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 1 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 1 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            if (cible.gethpv() <= 0)
                            {
                                Console.WriteLine("Le Joueur 2 a gagné !");
                                fin = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                jouer--;
                                Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (pdvSousZeroException)
                {
                    Console.WriteLine("Impossible de se battre, un des deux combattants est mort !!!");
                }
            }

        }

        public void accepterTournoiMagie()
        {
            int jouer = 0;
            bool fin = false;
            while (fin == false)
            {
                try
                {
                    if (tabJoueur[jouer].gethpv() > 0)
                    {
                        if (jouer == 0)
                        {
                            Personnage cible = tabJoueur[1];
                            if (tabJoueur[jouer].getClasses() == "Mage")
                            {
                                Console.WriteLine("Le joueur 1 attaque !");
                                int vieAvant = cible.gethpv();
                                ((Mage)tabJoueur[jouer]).attaqueSpecialeMagie(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            else if (tabJoueur[jouer].getClasses() == "Chaman")
                            {
                                Console.WriteLine("Le joueur 1 attaque !");
                                int vieAvant = cible.gethpv();
                                ((Healer)tabJoueur[jouer]).attaqueSpecialeMagie(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 2 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 2 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            if (cible.gethpv() <= 0)
                            {
                                Console.WriteLine("Le Joueur 1 a gagné !");
                                fin = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                jouer++;
                            }



                        }
                        else if (jouer == 1)
                        {
                            Personnage cible = tabJoueur[0];

                            if (tabJoueur[jouer].getClasses() == "Mage")
                            {
                                Console.WriteLine("Le joueur 2 attaque !");
                                int vieAvant = cible.gethpv();
                                ((Mage)tabJoueur[jouer]).attaqueSpecialeMagie(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 1 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 1 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            else if (tabJoueur[jouer].getClasses() == "Chaman")
                            {
                                Console.WriteLine("Le joueur 2 attaque !");
                                int vieAvant = cible.gethpv();
                                ((Healer)tabJoueur[jouer]).attaqueSpecialeMagie(cible);
                                int vieApres = cible.gethpv();
                                int degats = vieAvant - vieApres;
                                Console.WriteLine("Le joueur 1 a subi " + degats + "points de dégats");
                                Console.WriteLine("PV du joueur 1 : " + cible.gethpv());
                                Console.ReadLine();
                                degats = 0;
                            }
                            if (cible.gethpv() <= 0)
                            {
                                Console.WriteLine("Le Joueur 2 a gagné !");
                                fin = true;
                                Console.ReadLine();
                            }
                            else
                            {
                                jouer--;
                            }


                        }
                    }
                    else
                    {
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
