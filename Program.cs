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

            Console.WriteLine("MMO Mr.Braux");
            Console.WriteLine("Classe disponible Barbare = 1, Rogue = 2, Mage = 3, Healer = 4) \n");
            while (game == true)
            {
                Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                string Metier = Console.ReadLine();
                switch (Metier)
                {
                    case "1":
                        Metier = "Barbare";
                        Joueur = new Barbare();
                        Console.WriteLine("Barbare");
                        break;
                    case "2":
                        Metier = "Rogue";
                        Joueur = new Rogue();
                        Console.WriteLine("Rogue");
                        break;
                    case "3":
                        Metier = "Mage";
                        Joueur = new Mage();
                        Console.WriteLine("Mage");
                        break;
                    case "4":
                        Metier = "Healer";
                        Joueur = new Healer();
                        Console.WriteLine("Healer");
                        break;
                    default:
                        Console.WriteLine("Il n'existe pas d'autre classe \n");
                        game = false;
                        break;
                }
                /*
                while (Metier != "1" || Metier != "2")
                {
                    Console.WriteLine("Veuillez renseigner une classe valide opour pouvoir jouer !");
                    Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                    Metier = Console.ReadLine();

                    if (Metier == "1" || Metier == "2" && Metier != null || Metier == "")
                    {
                        Console.Clear();
                        if (Metier == "1" || Metier == "Barbare")
                        {
                            Metier = "Barbare";
                            Joueur = new Barbare();
                            Console.WriteLine("Barbare");
                            break;

                        }
                        else if (Metier == "2" || Metier == "Rogue")
                        {
                            Metier = "Rogue";
                            Joueur = new Rogue();
                            Console.WriteLine("Rogue");
                            break;
                        }
                        Console.WriteLine("Veuillez choisir une classe parmi celle proposée :");
                        Metier = Console.ReadLine();
                    }
                }*/

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
                    Joueur.Displays();
                    int sacMax = Joueur.getNbSacMax();
                    sacMax--;
                    Console.WriteLine("Nombre de sac max : " + sacMax+ "\n");
                    Console.WriteLine("Le premier sac est le sac 0 et le dernier est le sac " + sacMax + "\n");
                }
                game = false;
            }

            game = true;
            while (game == true)
            {   
                Console.WriteLine("|--------MENU PRINCIPAL----------|\n"+
                                  "|-1: Ajouter un item dans un sac-|\n" +
                                  "|-2: Afficher vos sac------------|\n" +
                                  "|-3: Retirer un item dans un sac-|\n" +
                                  "|-4: Afficher ses stats----------|\n" +
                                  "|-5: Ajouter un mate-------------|\n" +
                                  "|-6: Afficher ses states---------|\n" +
                                  "|-7: Rejoindre un tournoi--------|\n" +
                                  "|--------------------------------|" + "\n");
           
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
                            Joueur.Displays();
                            Joueur2.Displays();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Voulez-vous Ajouter un allié a votre team (oui ou non)" + "\n");
                        string Choix6 = Console.ReadLine();
                        if (Choix6 == "oui" || Choix6 == "OUI" || Choix6 == "Oui" || Choix6 == "O")
                        {
                            Console.Clear();
                            Console.WriteLine("Quelle classe voulez vous jouer ? (Barbare = 1, Rogue = 2, Mage = 3, Healer = 4)");
                            string Metier = Console.ReadLine();
                            switch (Metier)
                            {
                                case "1":
                                    Metier = "Barbare";
                                    Joueur2 = new Barbare();
                                    Console.WriteLine("Barbare");
                                    break;
                                case "2":
                                    Metier = "Rogue";
                                    Joueur2 = new Rogue();
                                    Console.WriteLine("Rogue");
                                    break;
                                case "3":
                                    Metier = "Mage";
                                    Joueur2 = new Mage();
                                    Console.WriteLine("Mage");
                                    break;
                                case "4":
                                    Metier = "Healer";
                                    Joueur2 = new Healer();
                                    Console.WriteLine("Healer");
                                    break;
                                default:
                                    Console.WriteLine("Il n'existe pas d'autre classe \n");
                                    game = false;
                                    break;
                            }

                            Console.WriteLine("Quel nom arborerez-vous, aventurier ?");
                            string nom1 = Console.ReadLine();
                            if (nom1 != null || nom1 == "")
                            {
                                while (nom1 == null || nom1 == "")
                                {
                                    Console.WriteLine("Votre nom aventurier ?");
                                    nom1 = Console.ReadLine();
                                }
                            }

                            if (nom1 != null || nom1 == "")
                            {
                                Console.Clear();
                                Console.WriteLine("|--------Personnage----------|" + "\n");
                                Console.WriteLine(" -->  Nom      : " + nom1 + "\n");
                                Joueur2.Displays();
                                 sacMax = Joueur2.getNbSacMax();
                                sacMax--;
                                Console.WriteLine("Nombre de sac max : " + sacMax + "\n");
                                Console.WriteLine("Le premier sac est le sac 0 et le dernier est le sac " + sacMax + "\n");
                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("Voulez-vous afficher votre team de héros (oui ou non)");
                        string Choix7 = Console.ReadLine();
                        if (Choix7 == "oui" || Choix7 == "OUI" || Choix7 == "Oui" || Choix7 == "O")
                        {
                            Joueur.afficherTeam();
                        }
                        break;

                    case "7":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois (oui ou non)");
                        string Choix8 = Console.ReadLine();
                        if (Choix8 == "oui" || Choix8 == "OUI" || Choix8 == "Oui" || Choix8 == "O")
                        {
                            Console.Clear();
                            /* Joueur.accepterTournoiArme(IAttaquantArme, IAttaquantArme);*/
                        }
                        break;

                    default:
                        Console.WriteLine("Il n'existe pas d'autre menu \n");
                        game = false;
                        break;
                }
                /*
                if (Choix1 == "oui")
                {
                    Console.WriteLine("Dans quel sac voulez-vous placer l'item");
                    string sac = Console.ReadLine();

                    Console.WriteLine("Qu'elle item voulez-vous placer dans votre sac " + sac);
                    string objets = Console.ReadLine();

                    Random rand = new Random();
                    int poids = 10;
                    poids = rand.Next(poids / 2, poids);

                    Joueur.ajouterItem(Convert.ToInt32(sac), new Objets(objets, poids));
                    Console.WriteLine("Voulez-vous afficher votre sac ? (oui ou non)");
                    string Choix2 = Console.ReadLine();
                    if (Choix2 == "oui")
                    {
                        Console.Clear();
                        Joueur.afficherSac(Convert.ToInt32(sac), new Objets(objets, poids));
                        Console.WriteLine(" Objets dans mon sac " + sac + " : " + objets, poids);
                    }
                }*/

            }
        }
    }
}
