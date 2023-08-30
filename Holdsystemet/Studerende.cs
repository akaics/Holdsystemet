using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holdsystemet
{
    public class Studerende
    {

        //instansfelter: 

        private int _id;
        private string _navn;
        private string _adresse;
        private string _cprNummer;


        //properties:

        //ID har betingelsen at den skal være over 1.
        public int ID
        {
            get { return _id; }
            set
            {
                if (value >= 1)
                {
                    _id = value;
                }

                else
                {
                    //Console.WriteLine("ID skal være større end 0.");
                    //Opgaven vil gerne have en throw Exception i stedet: 
                    throw new ArgumentException("ID skal være større end 0.");
                }
            }
        }
        

        public string Navn
        {
            get { return _navn; }
            set
            {
                if (value.Length >= 2)
                {
                    _navn = value;
                }
                else
                {
                    // Console.WriteLine("Navn skal være mindst 2 tegn langt.");
                    //Opgaven vil gerne have en throw Exception i stedet: 
                    throw new ArgumentException("Navn skal være mindst 2 tegn langt.");
                }
            }
        }



        
        public string Adresse { get; }  

        public string CprNummer
        {
            get { return _cprNummer; }
            set
            {
                if (value.Length == 10)
                {
                    _cprNummer = value;
                }
                else

                {
                    // Console.WriteLine("CPRNummer skal være præcist 10 tegn langt.");
                    //Opgaven vil gerne have en throw Exception i stedet: 
                    throw new ArgumentException("CPRNummer skal være præcist 10 tegn langt");
                }
            }
        }


        //konstruktør:

        public Studerende(int id, string navn, string adresse, string cprNummer)
        {
            ID = id;
            Navn = navn;
            Adresse = adresse;
            CprNummer = cprNummer;
        }

        //ToString() metode

        public override string ToString()
        {
            return $"ID: {ID}, Navn: {Navn}, Adresse: {Adresse}, CPRNummer: {CprNummer}" ;
        }

    }
}
