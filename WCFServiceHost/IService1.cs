using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
       
        [OperationContract]
        Korisnik Login(string username, string password);

        [OperationContract]
        Artikal Naruci(int id_artikla, int kolicina);

        [OperationContract]
        Artikal Prikazi(int i);

        /* [OperationContract]
         Artikal Napravi(); */


        // TODO: Add your service operations here
    }

    [DataContract]
    public class Korisnik
    {

        public Korisnik(string ime, string prezime, int id)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.id = id;
        }

        string ime;
        [DataMember]
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        string prezime;
        [DataMember]
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        int id;
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }

    [DataContract]
    public class Artikal
    {
        public Artikal(int id_artikla, string podaci, int kolicina)
        {

            this.id_artikla = id_artikla;
            this.podaci = podaci;
            this.kolicina = kolicina;


        }


        int id_artikla;
        [DataMember]
        public int Id_artikla
        {
            get { return id_artikla; }
            set { id_artikla = value; }


        }

        string podaci;
        [DataMember]
        public string Podaci
        {
            get { return podaci; }
            set { podaci = value; }


        }

       public int kolicina;
        [DataMember]
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }


        }



    }

    [DataContract]
    public class Porudzbine
    {


        [DataMember]
        public int Id_Porudzbine { get; set; }
        [DataMember]
        public int Id_artikl { get; set; }
        [DataMember]
        public int Id_Korisnik { get; set; }
        [DataMember]
        public int Kolicina { get; set; }


        public Porudzbine()
            {
                

            }


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
