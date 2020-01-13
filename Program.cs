using ProjetMMoMrBraux.Bataille;
using System;

namespace ProjetMMoMrBraux
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Personnage Joueur = null;
            Personnage Joueur2 = null;
            Personnage Joueur3 = null;
            Personnage Joueur4 = null;
            Personnage Joueur5 = null;
            Personnage Joueur6 = null;
            Console.WriteLine("MMO Mr.Braux");

            Console.WriteLine("Quel nom arborerez-vous, aventurier ?");
            string nom = Console.ReadLine();
            if (nom != null || nom == "")
            {
                while (nom == null || nom == "")
                {
                    Console.WriteLine("Votre nom aventurier ?");
                    nom = Console.ReadLine();
                }
            }

            if (nom != null || nom == "")
            {
                Console.Clear();
                Console.WriteLine("|--------Personnage----------|" + "\n");
                Console.WriteLine(" -->  Nom      : " + nom + "\n");
                Console.WriteLine("Classe disponible Barbare = 1, Rogue = 2, Mage = 3, Healer = 4) \n");
            while (game == true)
            {
                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                string Metier = Console.ReadLine();
                if ((Metier == "" || Metier == null ))
                {
                    while (Metier == "" || Metier == null)
                    {
                        Console.WriteLine("Votre Classe aventurier ?");
                        Metier = Console.ReadLine();                      
                    }
                }

                switch (Metier)
                {
                    case "1":
                        Metier = "Barbare";
                        Joueur = new Barbare(nom);
                        Console.WriteLine("Barbare");
                        break;
                    case "2":
                        Metier = "Rogue";
                        Joueur = new Rogue(nom);
                        Console.WriteLine("Rogue");
                        break;
                    case "3":
                        Metier = "Mage";
                        Joueur = new Mage(nom);
                        Console.WriteLine("Mage");
                        break;
                    case "4":
                        Metier = "Healer";
                        Joueur = new Healer(nom);
                        Console.WriteLine("Healer");
                        break;
                    default:
                        Console.WriteLine("Il n'existe pas d'autre classe \n");
                        game = false;
                        break;
                }

                    while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                    {
                        Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                        Metier = Console.ReadLine();

                            if ((Metier == "" || Metier == null))
                            {
                                while (Metier == "" || Metier == null)
                                {
                                    Console.WriteLine("Votre Classe aventurier ?");
                                    Metier = Console.ReadLine();
                                }
                            }

                            if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                            {
                                Console.Clear();
                                if (Metier == "1" || Metier == "Barbare")
                                {
                                    Metier = "Barbare";
                                    Joueur = new Barbare(nom);
                                    Console.WriteLine("Barbare");
                                    break;

                                }
                                else if (Metier == "2" || Metier == "Rogue")
                                {
                                    Metier = "Rogue";
                                    Joueur = new Rogue(nom);
                                    Console.WriteLine("Rogue");
                                    break;
                                }
                                else if (Metier == "3" || Metier == "Mage")
                                {
                                    Metier = "Mage";
                                    Joueur = new Rogue(nom);
                                    Console.WriteLine("Mage");
                                    break;
                                }
                                else if (Metier == "4" || Metier == "Healer")
                                {
                                    Metier = "Healer";
                                    Joueur = new Rogue(nom);
                                    Console.WriteLine("Healer");
                                    break;
                                }
                                else
                                    Console.WriteLine("Il n'existe pas d'autre classe \n");
                                Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                Metier = Console.ReadLine();
                            }
                        
                    }
       
                    Joueur.Displays();
                    int sacMax = Joueur.getNbSacMax();
                    sacMax--;
                    Console.WriteLine("Nombre de sac max : " + sacMax+ "\n");
                    Console.WriteLine("Le premier sac est le sac 0 et le dernier est le sac " + sacMax + "\n");
                    game = false;
                }
            
            }
            game = true;
            while (game == true)
            {   
                Console.WriteLine("|--------MENU PRINCIPAL------------|\n"+
                                  "|-1: Ajouter un item dans un sac---|\n" +
                                  "|-2: Afficher vos sac--------------|\n" +
                                  "|-3: Retirer un item dans un sac---|\n" +
                                  "|-4: Afficher ses stats------------|\n" +
                                  "|-5: Ajouter un mate---------------|\n" +
                                  "|-6: Afficher L'équipe-------------|\n" +
                                  "|-7: Rejoindre un tournoi Barbare--|\n" +
                                  "|-8: Rejoindre un tournoi Mage-----|\n" +
                                  "|-9: Rejoindre un tournoi Rogue----|\n" +
                                  "|-10: Rejoindre un tournoi Healer--|\n" +
                                  "|-11: Rejoindre un tournoi d'Arme--|\n" +
                                  "|-12: Rejoindre un tournoi de Magie|\n" +
                                  "|----------------------------------|" + "\n");
           
                string Choix1 = Console.ReadLine();
                int sacMax = Joueur.getNbSacMax();
                sacMax--;
             
                switch (Choix1)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Dans quel sac voulez-vous placer l'item, Nombre de sac entre 0 et " + sacMax);
                        string sac = Console.ReadLine();
                 
                            while (Convert.ToInt32(sac) > sacMax)
                            {
                                Console.WriteLine("Veuillez entrer un sac compris entre 0 et "+ sacMax);
                                sac = Console.ReadLine();
                            }

                        Console.WriteLine("Quel item voulez-vous placer dans votre sac " + sac);
                        string nomObjet = Console.ReadLine();
                        if (Joueur.countObjets(Convert.ToInt32(sac)) == true)
                        {
                            Joueur.ajouterItem(Convert.ToInt32(sac), new Objets(nomObjet, 10));
                        }
                        else
                            Console.WriteLine("Votre sac est complet ! Veuillez selectionner un nouveaux sac :" + "\n");

                        Console.WriteLine("Voulez-vous ajouter un autre item dans le meme sac ? (oui ou non)" + "\n");
                            string Choix5 = Console.ReadLine();
                            while (Choix5 == "oui" || Choix5 == "OUI" || Choix5 == "Oui" || Choix5 == "O" || Choix5 == "o")
                            {
                            if (Joueur.countObjets(Convert.ToInt32(sac)) == true)
                            {
                                Console.WriteLine("Quel item voulez-vous placer dans votre sac " + sac);
                                nomObjet = Console.ReadLine();
                           
                            
                                Joueur.ajouterItem(Convert.ToInt32(sac), new Objets(nomObjet, 100));
                                Console.WriteLine("Voulez-vous ajouter un autre item dans le meme sac " + sac + " ? (oui ou non)");
                                Choix5 = Console.ReadLine();
                            }
                            else
                                Console.WriteLine("Votre sac est complet ! Veuillez selectionner un nouveaux sac !" + "\n");
                                break;                                                                             
                            }                
                           break;

                    case "2":     
                            Console.Clear();
                            Console.WriteLine("Dans quel sac voulez-vous prendre l'item, Nombre de sac entre 1 et " + Joueur.getNbSacMax());
                            sac = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("La liste de vos items dans le sac "+sac);
                        Joueur.afficherSac(Convert.ToInt32(sac));              
                        break;
                    case "3":
                        Console.WriteLine("Dans quel sac voulez-vous retirer l'item, Nombre de sac entre 1 et " + Joueur.getNbSacMax());
                        sac = Console.ReadLine();
                        Console.WriteLine("veuillez renseigner le nom de l'item que vous souhaitez retirer du sac numréro " + sac+" :");
                        Joueur.afficherSac(Convert.ToInt32(sac));
                        string Remove = Console.ReadLine();
                        Joueur.retirerItem(Convert.ToInt32(sac), new Objets(Remove, 100));
                        break;

                    case "4":
                        Console.WriteLine("Voulez-vous afficher vos stats ? (oui ou non)" + "\n");
                        string Choix4 = Console.ReadLine();
                        if (Choix4 == "oui")
                        {
                            Console.Clear();
                            if (Joueur != null)
                            {
                                Joueur.Displays();
                                Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                string ChoixD = Console.ReadLine();
                                if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                {
                                    Joueur.afficherArme();
                                }
                            }
                            else
                                Console.WriteLine("Pas de personnage");                         
                        }
                        break;

                    case "5":
                            Console.WriteLine("Voulez-vous Ajouter un allié a votre team (oui ou non) 6 alliés Max !" + "\n");
                            string Choix6 = Console.ReadLine();

                        if ((Choix6 == "" || Choix6 == null))
                        {
                            while (Choix6 == "" || Choix6 == null)
                            {
                                Console.WriteLine("Votre Slote aventurier ?");
                                Choix6 = Console.ReadLine();
                            }
                        }
                        if (Choix6 == "oui" || Choix6 == "OUI" || Choix6 == "Oui" || Choix6 == "O")
                            {
                            Console.Clear();

                            Console.WriteLine("Veuillez choisir un slote disponible pour votre nouveau personnage :");
                            Console.WriteLine("|--------MENU PERSONNAGE---------|\n" +
                                              "|-1: Slote Personnage 2----------|\n" +
                                              "|-2: Slote Personnage 3----------|\n" +
                                              "|-3: Slote Personnage 4----------|\n" +
                                              "|-4: Slote Personnage 5----------|\n" +
                                              "|-5: Slote Personnage 6----------|\n" +
                                              "|--------------------------------|" + "\n");

                            string Slote = Console.ReadLine();
                            if (Slote != null || Slote == "")
                            {
                                while (Slote == null || Slote == "")
                                {
                                    Console.WriteLine("Votre slote ?");
                                    Slote = Console.ReadLine();
                                }
                            }
                            
                            if (Slote == "1")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 2 ?");
                                string nom2 = Console.ReadLine();
                                if (nom2 != null || nom2 == "")
                                {
                                    while (nom2 == null || nom2 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom2 = Console.ReadLine();
                                    }
                                }

                                if (nom2 != null || nom2 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 2----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom2 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur2 = new Barbare(nom2);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur2 = new Rogue(nom2);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur2 = new Mage(nom2);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur2 = new Healer(nom2);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur2 = new Barbare(nom2);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur2 = new Rogue(nom2);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur2 = new Rogue(nom2);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur2 = new Rogue(nom2);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 2 créé avec succes ! \n");
                            }
                            else if (Slote == "2")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 2 ?");
                                string nom3 = Console.ReadLine();
                                if (nom3 != null || nom3 == "")
                                {
                                    while (nom3 == null || nom3 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom3 = Console.ReadLine();
                                    }
                                }

                                if (nom3 != null || nom3 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 3----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom3 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur3 = new Barbare(nom3);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur3 = new Rogue(nom3);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur3 = new Mage(nom3);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur3 = new Healer(nom3);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur3 = new Barbare(nom3);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur3 = new Rogue(nom3);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur3 = new Rogue(nom3);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur3 = new Rogue(nom3);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 3 créé avec succes ! \n");
                            }
                            else if (Slote == "3")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 4 ?");
                                string nom4 = Console.ReadLine();
                                if (nom4 != null || nom4 == "")
                                {
                                    while (nom4 == null || nom4 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom4 = Console.ReadLine();
                                    }
                                }

                                if (nom4 != null || nom4 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 4----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom4 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur4 = new Barbare(nom4);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur4 = new Rogue(nom4);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur4 = new Mage(nom4);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur4 = new Healer(nom4);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur4 = new Barbare(nom4);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur4 = new Rogue(nom4);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur4 = new Rogue(nom4);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur4 = new Rogue(nom4);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 4 créé avec succes ! \n");
                            }
                            else if (Slote == "4")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 5 ?");
                                string nom5 = Console.ReadLine();
                                if (nom5 != null || nom5 == "")
                                {
                                    while (nom5 == null || nom5 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom5 = Console.ReadLine();
                                    }
                                }

                                if (nom5 != null || nom5 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 5----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom5 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur5 = new Barbare(nom5);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur5 = new Rogue(nom5);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur5 = new Mage(nom5);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur5 = new Healer(nom5);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur5 = new Barbare(nom5);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur5 = new Rogue(nom5);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur5 = new Rogue(nom5);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur5 = new Rogue(nom5);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 5 créé avec succes ! \n");
                            }
                            else if (Slote == "5")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 5 ?");
                                string nom6 = Console.ReadLine();
                                if (nom6 != null || nom6 == "")
                                {
                                    while (nom6 == null || nom6 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom6 = Console.ReadLine();
                                    }
                                }

                                if (nom6 != null || nom6 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 6----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom6 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur6 = new Barbare(nom6);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur6 = new Rogue(nom6);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur6 = new Mage(nom6);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur6 = new Healer(nom6);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur6 = new Barbare(nom6);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur6 = new Rogue(nom6);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur6 = new Rogue(nom6);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur6 = new Rogue(nom6);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 6 créé avec succes ! \n");
                            }
                        }else
                            Console.Clear();
                            Console.WriteLine("Voulez-vous créer un autre personnage ? (oui/non) \n");
                            string ajout = Console.ReadLine();
                        Console.WriteLine("ajout :"+ ajout );
                
                        if ((ajout == "" || ajout == null))
                        {
                            while (ajout == "" || ajout == null)
                            {
                                Console.WriteLine("Votre choix aventurier ?");
                                ajout = Console.ReadLine();
                            }
                        }
                  
                        while (ajout == "oui" || ajout == "OUI" || ajout == "O" || ajout == "o")
                        {
                      
                            Console.WriteLine("Veuillez choisir un slote disponible pour votre nouveau personnage :");
                            string Slote = Console.ReadLine();
                            if (Slote == "1")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 2 ?");
                                string nom2 = Console.ReadLine();
                                if (nom2 != null || nom2 == "")
                                {
                                    while (nom2 == null || nom2 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom2 = Console.ReadLine();
                                    }
                                }

                                if (nom2 != null || nom2 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 2----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom2 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur2 = new Barbare(nom2);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur2 = new Rogue(nom2);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur2 = new Mage(nom2);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur2 = new Healer(nom2);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur2 = new Barbare(nom2);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur2 = new Rogue(nom2);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur2 = new Rogue(nom2);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur2 = new Rogue(nom2);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 2 créé avec succes ! \n");
                            }
                            else if (Slote == "2")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 2 ?");
                                string nom3 = Console.ReadLine();
                                if (nom3 != null || nom3 == "")
                                {
                                    while (nom3 == null || nom3 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom3 = Console.ReadLine();
                                    }
                                }

                                if (nom3 != null || nom3 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 3----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom3 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur3 = new Barbare(nom3);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur3 = new Rogue(nom3);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur3 = new Mage(nom3);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur3 = new Healer(nom3);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur3 = new Barbare(nom3);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur3 = new Rogue(nom3);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur3 = new Rogue(nom3);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur3 = new Rogue(nom3);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 3 créé avec succes ! \n");
                            }
                            else if (Slote == "3")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 4 ?");
                                string nom4 = Console.ReadLine();
                                if (nom4 != null || nom4 == "")
                                {
                                    while (nom4 == null || nom4 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom4 = Console.ReadLine();
                                    }
                                }

                                if (nom4 != null || nom4 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 4----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom4 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur4 = new Barbare(nom4);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur4 = new Rogue(nom4);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur4 = new Mage(nom4);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur4 = new Healer(nom4);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur4 = new Barbare(nom4);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur4 = new Rogue(nom4);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur4 = new Rogue(nom4);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur4 = new Rogue(nom4);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 4 créé avec succes ! \n");
                            }
                            else if (Slote == "4")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 5 ?");
                                string nom5 = Console.ReadLine();
                                if (nom5 != null || nom5 == "")
                                {
                                    while (nom5 == null || nom5 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom5 = Console.ReadLine();
                                    }
                                }

                                if (nom5 != null || nom5 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 5----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom5 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur5 = new Barbare(nom5);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur5 = new Rogue(nom5);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur5 = new Mage(nom5);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur5 = new Healer(nom5);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur5 = new Barbare(nom5);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur5 = new Rogue(nom5);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur5 = new Rogue(nom5);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur5 = new Rogue(nom5);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 5 créé avec succes ! \n");
                            }
                            else if (Slote == "5")
                            {

                                Console.WriteLine("Quel nom arborerez-vous, aventurier 5 ?");
                                string nom6 = Console.ReadLine();
                                if (nom6 != null || nom6 == "")
                                {
                                    while (nom6 == null || nom6 == "")
                                    {
                                        Console.WriteLine("Votre nom aventurier ?");
                                        nom6 = Console.ReadLine();
                                    }
                                }

                                if (nom6 != null || nom6 == "")
                                {
                                    Console.Clear();
                                    Console.WriteLine("|--------Personnage 6----------|" + "\n");
                                    Console.WriteLine(" -->  Nom      : " + nom6 + "\n");
                                }


                                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                                string Metier = Console.ReadLine();
                                switch (Metier)
                                {
                                    case "1":
                                        Metier = "Barbare";
                                        Joueur6 = new Barbare(nom6);
                                        Console.WriteLine("Barbare");
                                        break;
                                    case "2":
                                        Metier = "Rogue";
                                        Joueur6 = new Rogue(nom6);
                                        Console.WriteLine("Rogue");
                                        break;
                                    case "3":
                                        Metier = "Mage";
                                        Joueur6 = new Mage(nom6);
                                        Console.WriteLine("Mage");
                                        break;
                                    case "4":
                                        Metier = "Healer";
                                        Joueur6 = new Healer(nom6);
                                        Console.WriteLine("Healer");
                                        break;
                                    default:
                                        Console.WriteLine("Il n'existe pas d'autre classe ! \n");
                                        game = false;
                                        break;
                                }

                                while (Metier != "Barbare" && Metier != "Rogue" && Metier != "Mage" && Metier != "Healer")
                                {
                                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                    Metier = Console.ReadLine();

                                    if ((Metier == "" || Metier == null))
                                    {
                                        while (Metier == "" || Metier == null)
                                        {
                                            Console.WriteLine("Votre Classe aventurier ?");
                                            Metier = Console.ReadLine();
                                        }
                                    }

                                    if (Metier == "1" || Metier == "2" || Metier == "3" || Metier == "4")
                                    {
                                        Console.Clear();
                                        if (Metier == "1" || Metier == "Barbare")
                                        {
                                            Metier = "Barbare";
                                            Joueur6 = new Barbare(nom6);
                                            Console.WriteLine("Barbare");
                                            break;

                                        }
                                        else if (Metier == "2" || Metier == "Rogue")
                                        {
                                            Metier = "Rogue";
                                            Joueur6 = new Rogue(nom6);
                                            Console.WriteLine("Rogue");
                                            break;
                                        }
                                        else if (Metier == "3" || Metier == "Mage")
                                        {
                                            Metier = "Mage";
                                            Joueur6 = new Rogue(nom6);
                                            Console.WriteLine("Mage");
                                            break;
                                        }
                                        else if (Metier == "4" || Metier == "Healer")
                                        {
                                            Metier = "Healer";
                                            Joueur6 = new Rogue(nom6);
                                            Console.WriteLine("Healer");
                                            break;
                                        }
                                        else
                                            Console.WriteLine("Il n'existe pas d'autre classe \n");
                                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                                        Metier = Console.ReadLine();
                                    }
                                }
                                Console.WriteLine("Personnage 6 créé avec succes ! \n");
                            }

                        }

                        break;

                    case "6":
                        Console.WriteLine("Voulez-vous afficher votre team de héros (oui ou non)");
                        string Choix7 = Console.ReadLine();
                        if (Choix7 == "oui" || Choix7 == "OUI" || Choix7 == "Oui" || Choix7 == "O")
                        {
                           // Joueur.afficherTeam();
                            if (Joueur != null)
                            {
                                Joueur.Displays();
                                Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                string ChoixD = Console.ReadLine();
                                if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                {
                                    Joueur.afficherArme();
                                }
                            }
                            else
                                Console.WriteLine("Pas d'autre personnage");
                            if (Joueur2 != null)
                            {
                                Joueur2.Displays();
                                if (Joueur2 != null)
                                {
                                    Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                    string ChoixD = Console.ReadLine();
                                    if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                    {
                                        Joueur2.afficherArme();
                                    }
                                }
                            }
                            else
                                Console.WriteLine("Pas d'autre personnage 2");
                            if (Joueur3 != null)
                            {
                                Joueur3.Displays();
                                if (Joueur3 != null)
                                {
                                    Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                    string ChoixD = Console.ReadLine();
                                    if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                    {
                                        Joueur3.afficherArme();
                                    }
                                }
                            }
                            else
                                Console.WriteLine("Pas d'autre personnage 3");
                            if (Joueur4 != null)
                            {
                                Joueur4.Displays();
                                if (Joueur4 != null)
                                {
                                    Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                    string ChoixD = Console.ReadLine();
                                    if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                    {
                                        Joueur4.afficherArme();
                                    }
                                }
                            }
                            else
                                Console.WriteLine("Pas d'autre personnage 4");
                            if  (Joueur5 != null)
                            {
                                Joueur5.Displays();
                          
                                if(Joueur5 != null)
                                {
                                    Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                    string ChoixD = Console.ReadLine();
                                    if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                    {
                                        Joueur5.afficherArme();
                                    }
                                }
                          
                            }
                            else
                                Console.WriteLine("Pas d'autre personnage 5");
                            if (Joueur6 != null)
                            {
                                Joueur6.Displays();

                                if (Joueur6 != null)
                                {
                                    Console.WriteLine("Veux-tu afficher les détails de ton arme ?");
                                    string ChoixD = Console.ReadLine();
                                    if (ChoixD == "oui" || ChoixD == "OUI" || ChoixD == "Oui" || ChoixD == "O")
                                    {
                                        Joueur6.afficherArme();
                                    }
                                }

                            }
                            else
                                Console.WriteLine("Pas d'autre personnage 6");
                        }
                  
                        break;

                    case "7":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois de Barbare (oui ou non)");
                        string Choix8 = Console.ReadLine();
                        if (Choix8 == "oui" || Choix8 == "OUI" || Choix8 == "Oui" || Choix8 == "O")
                        {
                            Console.Clear();
                            Tournois tournoi = new Tournois();
                            //Console.WriteLine("Selection de l'arme du combatant 1 :");
                            Barbare Combatant1 = new Barbare("Combattant 1  ");
                            Console.WriteLine("Combatant Barbare 1 stats : ");
                            Combatant1.Displays();
                            Barbare Combatant2 = new Barbare("Combattant 2 ");
                            Console.WriteLine("Combatant Barbare 2 stats : ");
                            Combatant2.Displays();
                            //Joueur.afficherArme();
                            //Console.WriteLine("Selection de l'arme du combatant 2 :");                           
                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());
                            tournoi.accepterTournoi(Combatant1, Combatant2);
                            Console.WriteLine("Point de vie du combatant 1 : " + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 : " + Combatant2.gethpv());

                        }
                        break;

                    case "8":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois de Mage (oui ou non)");
                        string Choix9 = Console.ReadLine();
                        if (Choix9 == "oui" || Choix9 == "OUI" || Choix9 == "Oui" || Choix9 == "O")
                        {

                            Console.Clear();
                            Tournois tournoi = new Tournois();
                            //Console.WriteLine("Selection de l'arme du combatant 1 :");
                            Mage Combatant1 = new Mage("Combattant 1 ");
                            Console.WriteLine("Combatant Mage 1 stats : ");
                            Combatant1.Displays();
                            Mage Combatant2 = new Mage("Combattant 2 ");
                            Console.WriteLine("Combatant  Mage 2 stats : ");
                            Combatant2.Displays();
                            //Joueur.afficherArme();
                            //Console.WriteLine("Selection de l'arme du combatant 2 :");

                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());
                            tournoi.accepterTournoi(Combatant1, Combatant2);
                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());

                        }
                        break;

                    case "9":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois de Rogue (oui ou non)");
                        string Choix10 = Console.ReadLine();
                        if (Choix10 == "oui" || Choix10 == "OUI" || Choix10 == "Oui" || Choix10 == "O")
                        {

                            Console.Clear();
                            Tournois tournoi = new Tournois();
                            //Console.WriteLine("Selection de l'arme du combatant 1 :");
                            Rogue Combatant1 = new Rogue("Combattant 1 ");
                            Console.WriteLine("Combatant  Rogue 2 stats : ");
                            Combatant1.Displays();
                            Rogue Combatant2 = new Rogue("Combattant 2 ");
                            Console.WriteLine("Combatant  Rogue 2 stats : ");
                            Combatant2.Displays();
                            //Joueur.afficherArme();
                            //Console.WriteLine("Selection de l'arme du combatant 2 :");

                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());
                            tournoi.accepterTournoi(Combatant1, Combatant2);
                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());

                        }
                        break;

                    case "10":

                        Console.WriteLine("Voulez-vous rejoindre un Tournois de Healer (oui ou non)");
                        string Choix11 = Console.ReadLine();
                        if (Choix11 == "oui" || Choix11 == "OUI" || Choix11 == "Oui" || Choix11 == "O")
                        {

                            Console.Clear();
                            Tournois tournoi = new Tournois();
                            //Console.WriteLine("Selection de l'arme du combatant 1 :");
                            Healer Combatant1 = new Healer("Combattant 1 ");
                            Console.WriteLine("Combatant  Healer 2 stats : ");
                            Combatant1.Displays();
                            Healer Combatant2 = new Healer("Combattant 2 ");
                            Console.WriteLine("Combatant  Healer 2 stats : ");
                            Combatant2.Displays();
                            //Joueur.afficherArme();
                            //Console.WriteLine("Selection de l'arme du combatant 2 :");

                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());
                            tournoi.accepterTournoi(Combatant1, Combatant2);
                            Console.WriteLine("Point de vie du combatant 1 :" + Combatant1.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Combatant2.gethpv());

                        }
                        break;

                    case "11":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois de Combattant Arme Barbare vs Rogue (oui ou non)");
                        string Choix12 = Console.ReadLine();
                        if (Choix12 == "oui" || Choix12 == "OUI" || Choix12 == "Oui" || Choix12 == "O")
                        {
                            if (Joueur == null || Joueur2 == null)
                            {
                                if( Joueur == null)
                                {
                                    Console.WriteLine("Pas de personnage 1 !!");
                                }
                                else if(Joueur2 == null){
                                    Console.WriteLine("Pas de personnage 2 !!");
                                }
                              
                                Console.WriteLine("Veuillez composer le slot 3 et 4 de votre team de Mage ou Healer !!");
                                break;
                            }

                            Console.Clear();
                            Console.WriteLine("Combatant  "+Joueur+" stats : ");
                            Joueur.Displays();
                            Console.WriteLine("Combatant  " + Joueur2 + " stats : ");
                            Joueur2.Displays();
                            Tournoi tournoi1 = new Tournoi(Joueur, Joueur2);
                            Console.WriteLine("////////////Tounois Arme/////////////");
                            Console.WriteLine("Point de vie du combatant 1 :" + Joueur.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Joueur2.gethpv());
                            tournoi1.accepterTournoiArme();
                            Console.WriteLine("Point de vie du combatant 1 :" + Joueur.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Joueur2.gethpv());

                        }
                        break;
                    case "12":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois de Combattant Magie (oui ou non)");
                        string Choix13 = Console.ReadLine();
                        if (Choix13 == "oui" || Choix13 == "OUI" || Choix13 == "Oui" || Choix13 == "O")
                        {
                            if (Joueur3 == null || Joueur4 == null)
                            {
                                if (Joueur3 == null)
                                {
                                    Console.WriteLine("Pas de personnage 1 !!");
                                }
                                else if (Joueur4 == null)
                                {
                                    Console.WriteLine("Pas de personnage 2 !!");
                                }
                                Console.WriteLine("Veuillez composer le slot 2  team de Rogue ou Barbare !!");
                                break;
                            }
                            Console.Clear();
                            Tournoi tournoi1 = new Tournoi(Joueur3, Joueur4);
                            Console.WriteLine("Combatant  " + Joueur3 + " stats : ");
                            Joueur3.Displays();
                            Console.WriteLine("Combatant  " + Joueur4 + " stats : ");
                            Joueur4.Displays();
                            Console.WriteLine("////////////Tounois Magie/////////////");
                            Console.WriteLine("Point de vie du combatant 1 :" + Joueur.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Joueur2.gethpv());
                            tournoi1.accepterTournoiMagie();
                            Console.WriteLine("Point de vie du combatant 1 :" + Joueur.gethpv());
                            Console.WriteLine("Point de vie du combatant 2 :" + Joueur2.gethpv());

                        }
                        break;

                    default:
                        Console.WriteLine("Il n'existe pas d'autre menu \n");
                        game = false;
                        break;
                }
                
            }
        }
    }
}
