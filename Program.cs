using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        string[] listeMots = {"Pierre", "Papier", "Ciseaux"};

        Console.WriteLine("\t Jeu du Pierre-Papier-Ciseaux");
        Console.WriteLine("***Règle du jeu***");
        Console.WriteLine("-La pierre l'emporte sur le ciseaux");
        Console.WriteLine("-Le papier l'emporte sur la pierre");
        Console.WriteLine("-Le ciseaux l'emporte sur le papier");
        Console.WriteLine("--------------------------------\n");

        string entrer;
        int choix;
        String Pie = "Pierre";
        String Pap = "Papier";
        String Cis = "Ciseaux";

        void afficheSeconde(){

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine("Resultat dans  {0} seconde(s)...", i);
                Thread.Sleep(1000);
            }
        }

        string Resultat(string mot){

            int indexAleatoire = rand.Next(listeMots.Length);
            string motAleatoire = listeMots[indexAleatoire];

            if (motAleatoire == mot){
                return Resultat(mot);
            }
            else{
                return motAleatoire;
            }
        }

        Console.WriteLine("Choisissez : \n1-Pierre \n2-Papier \n3-Ciseaux");
        Console.Write("Inconnu - ");
        entrer = Console.ReadLine();
        choix = Convert.ToInt32(entrer);

        string motparam;

        void Success(String pipasi,String rep){


            if(pipasi == "Pierre" && Resultat(rep) == "Papier"){
                 Console.WriteLine("Désolé vous avez perdu :( ");

            }else if(pipasi == "Pierre" && Resultat(rep) == "Ciseaux"){
                 Console.WriteLine("Bravo vous avez gagnez ;) ");

            }else if(pipasi == "Papier" && Resultat(rep) == "Pierre"){
                 Console.WriteLine("Bravo vous avez gagnez ;) ");

            }else if(pipasi == "Papier" && Resultat(rep) == "Ciseaux"){
                 Console.WriteLine("Désolé vous avez perdu :(");

            }else if(pipasi == "Ciseaux" && Resultat(rep) == "Papier"){
                 Console.WriteLine("Désolé vous avez perdu :(");

            }else if(pipasi == "Ciseaux" && Resultat(rep) == "Pierre"){
                 Console.WriteLine("Bravo vous avez gagnez ;) ");
            }
        }

        switch (choix)
        {
            case 1:
                Console.WriteLine("Choix : Pierre ");
                afficheSeconde();
                motparam = "Pierre";
                Console.WriteLine( Pie +" - " + Resultat(motparam));
                Success(Pie,motparam);
                break;
            case 2:
                Console.WriteLine("Choix : Papier ");
                afficheSeconde();
                motparam = "Papier";
                Console.WriteLine( Pap +" - " + Resultat(motparam));
                Success(Pap,motparam);
                break;
            case 3:
                Console.WriteLine("Choix : Ciseaux ");
                afficheSeconde();
                motparam = "Ciseaux";
                Console.WriteLine( Cis +" - " + Resultat(motparam));
                Success(Cis,motparam);
                break;
            default:
                Console.WriteLine("Votre choix n'est pas correct");
                break;
        }
    }
}

