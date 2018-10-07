using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFServiceHost
{
    class Program
    {

      //  public static List<Artikal> artikli = new List<Artikal>();


        static void Main(string[] args)
        {


            Console.WriteLine("Pokretanje servisa");
            ServiceHost host = new ServiceHost(typeof(Service1));


            

            host.Open();

            
           

            Console.WriteLine("Servis uspesno pokrenut");
            Console.ReadLine();
        }


     /*   public void Napravi()
        {

            Artikal a;




            a = new Artikal(0, "Zajecarsko", 5);
            artikli.Add(a);

            a = new Artikal(2, "Jelen", 4);
            artikli.Add(a);
            a = new Artikal(4, "Tuborg", 12);
            artikli.Add(a);
            a = new Artikal(3, "Lowensbrau", 4);
            artikli.Add(a);
            a = new Artikal(1, "Jelen", 4);
            artikli.Add(a);

            Console.WriteLine("Artikli napravljeni");
          //  return new Artikal(1, "Lav", 6);

        }
        */

    }
}
