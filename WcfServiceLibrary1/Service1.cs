using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public static List<Artikal> artikli ;


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Korisnik Login(string username, string password)
        {

            artikli = new List<Artikal>();
            Napravi();


            if (username == "damjan" && password == "sifra")
                return new Korisnik("Damjan", "Grbovic", 0);
            return null;
        }


        public Artikal Naruci(int id_artikla, int kolicina)
        {
          //  Napravi();


            if (id_artikla < 0 || id_artikla > 7)
            {
                Console.WriteLine("Neispravan artikal");
                return null;
            }


            if(artikli[id_artikla].kolicina <= 0)
            {
                Console.WriteLine("Nema vise tog piva");
                return null;

            }
            if (artikli[id_artikla].kolicina < kolicina)
            {
                Console.WriteLine("Nemamamo piva koliko trazite. Imamo "+ artikli[id_artikla].kolicina);
                return null;

            }

            artikli[id_artikla].kolicina -= kolicina;

            


            return artikli[id_artikla];


           /*
            if (id_artikla == 0 && kolicina > 0)
                return new Artikal(0, "Zajecarsko", 5);
            return null;
            */
        }

        public void Napravi()
        {
          

            Artikal a;


            

            a = new Artikal(0, "Zajecarsko", 55);
            artikli.Add(a);

            a = new Artikal(1, "Jelen", 34);
            artikli.Add(a);
            a = new Artikal(2, "Tuborg", 12);
            artikli.Add(a);
            a = new Artikal(3, "Lowensbrau", 24);
            artikli.Add(a);
            a = new Artikal(4, "Valjevsko", 19);
            artikli.Add(a);
            a = new Artikal(5, "Jagodinsko", 24);
            artikli.Add(a);
            a = new Artikal(6, "Lasko", 44);
            artikli.Add(a);
            a = new Artikal(7, "Baltika", 14);
            artikli.Add(a);



            //   Console.WriteLine("Artikli napravljeni");
            // return  new Artikal(1,"Lav", 6);

        }
        

        public Artikal Prikazi(int i)
        {


            return artikli[i];

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
