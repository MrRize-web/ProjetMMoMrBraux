using System;

namespace ProjetMMoMrBraux
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Personnage Joueur = null;

            Console.WriteLine("MMO Mr Braux");
            Console.WriteLine("Classe disponible Barbare = 1, Rogue = 2 \n");
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
                                  "|-4: Afficher ses states---------|\n" +
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
                        
                        Console.WriteLine("Qu'elle item voulez-vous placer dans votre sac " + sac);
                        string nomObjet = Console.ReadLine();
               
                        Joueur.ajouterItem(Convert.ToInt32(sac), new Objets(nomObjet,10));

                        Console.WriteLine("Voulez-vous ajouter un autre item dans le meme sac ? (oui ou non)");
                        string Choix5 = Console.ReadLine();
                       while (Choix5 == "oui")
                        {
                            Console.WriteLine("Qu'elle item voulez-vous placer dans votre sac " + sac);
                            nomObjet = Console.ReadLine();
                            int i = 1;
                            Joueur.ajouterItem(Convert.ToInt32(sac), new Objets(nomObjet,100));
                            i++;                                 
                            if (i >= 5)
                            {
                                Console.WriteLine("Votre sac est complet ! Veuillez selectionner un nouveaux sac :");
                                break;
                            }
                            else
                                Console.WriteLine("Voulez-vous ajouter un autre item dans le meme sac "+sac+" ? (oui ou non)");
                            Choix5 = Console.ReadLine();
                          
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
                        Console.WriteLine("Voulez-vous afficher vos states ? (oui ou non)" + "\n");
                        string Choix4 = Console.ReadLine();
                        if (Choix4 == "oui")
                        {
                            Console.Clear();
                            Joueur.Displays();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Voulez-vous rejoindre un Tournois (oui ou non)");
                        string Choix6 = Console.ReadLine();
                        if (Choix6 == "oui")
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
