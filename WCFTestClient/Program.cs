using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCFTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tacno=true;




            while(tacno)
            {
                Console.WriteLine("Username : ");
                string username = Console.ReadLine();

                Console.WriteLine("Password : ");
                string pass = Console.ReadLine();

                ServiceReference1.Service1Client servis = new ServiceReference1.Service1Client();
                ServiceReference1.Korisnik k = servis.Login(username, pass);

                if (k == null)
                    Console.WriteLine("Neuspesna prijava");
                else
                {
                    Console.WriteLine("Welcome , " + k.Ime + " " + k.Prezime);
                    break;
                }

                
            }


            while (true)
            {

                Console.WriteLine("Da li zelite da narucite ili da pogledate proizvode? (narucim/pogledam)");
                string izbor = Console.ReadLine();

                if (izbor == "pogledam")
                {





                    int i;

                    for (i = 0; i < 7; i++)
                    {

                        ServiceReference1.Service1Client servis1 = new ServiceReference1.Service1Client();
                        ServiceReference1.Artikal a = servis1.Prikazi(i);
                        Console.WriteLine("" + a.Id_artikla + " , " + a.Kolicina + " , " + a.Podaci);
                        Console.WriteLine("\r\n");

                    }




                }


                if (izbor == "narucim")
                    while (tacno)
                    {

                        Console.WriteLine("Id artikla : ");
                        int id_artikla = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Kolicina : ");
                        int kolicina = Convert.ToInt32(Console.ReadLine());

                        /*  ServiceReference1.Service1Client servis1 = new ServiceReference1.Service1Client();
                          ServiceReference1.Artikal a = servis1.Napravi(); */



                        ServiceReference1.Service1Client servis2 = new ServiceReference1.Service1Client();
                        ServiceReference1.Artikal b = servis2.Naruci(id_artikla, kolicina);


                        if (b == null)
                        {
                            Console.WriteLine("Neuspesna narudzbina");
                            Console.WriteLine("Da li zelite ponovo da probate? (da/ne)");
                            string izbor1 = Console.ReadLine();

                            if (izbor1 == "ne")
                                break;

                        }
                        else
                        {
                            Console.WriteLine("Narucili ste " + b.Podaci + ", komada " + kolicina );
                            Console.WriteLine("Da li zelite ponovo da narucite? (da/ne)");
                            string izbor2 = Console.ReadLine();

                            if (izbor2 == "ne")
                                break;
                        }

                    }

                Console.WriteLine("Da li zelite da napustite program? (da za izlaz)");

                string izbor3 = Console.ReadLine();

                if (izbor3 == "da")
                    break;


            }
            Console.WriteLine("Kraj programa (Enter)");
            Console.ReadLine();
        }
    }
}
