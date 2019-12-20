using System;

namespace Revisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int chiffre = 15;
            //string mot = "table";
            //bool choix = true;

            //chiffre += 8;
            //chiffre = chiffre + 8;

            //mot += " - " + chiffre;
            //mot = String.Format("{0} - {1}", mot, chiffre);

            //chiffre += 12;

            //if (choix)
            //{
            //    Console.WriteLine(mot);
            //} else
            //{
            //    Console.WriteLine(chiffre);
            //}


            //Console.WriteLine(choix ? mot : chiffre.ToString());


            //switch (chiffre)
            //{
            //    case 5:
            //        Console.WriteLine("Jaune");
            //        break;

            //    case 8:
            //        Console.WriteLine("Bleu");
            //        break;

            //    default:
            //        Console.WriteLine("Rouge");
            //        break;
            //}

            //for(int i = 0 ; i < 10; i++) {

            //}

            //int j = 100;
            //while(j < 10)
            //{

            //    j++;

            //}

            //do
            //{
            //    j++;
            //} while (j < 10);

            //MaClasse classe = new MaClasse("Polymorphisme");

            //ClasseFormation classeF = new ClasseFormation(5, "Revision");


            Voiture car = new Voiture("HDGD 74", "rouge");

            car.demarrer();
            car.accelerer();



            Batmobile batmobile = new Batmobile("BATMOBILE", "reacteur");

            batmobile.demarrer();
            batmobile.accelerer();


            Velo velo = new Velo();

            Avion plane = new Avion();

            faireAvancer(car);
            faireAvancer(batmobile);

            faireAvancer(velo);
            faireAvancer(plane);



        }


        static void faireAvancer(IVehicul car)
        {
            car.rouler();
        }
    }
}
