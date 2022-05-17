using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraçSorusuProjesi
{
    enum markalar
    {
        Honda, Mazda, Ford, Mercedes, Renault, Toyota, Tofas, Lamborghini, Ferrari, Scania, Volvo
    }
    enum vites
    {
        Manuel, Otomatik, Yarı_Otomatik
    }
    enum renk
    {
        Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor
    }
  


    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil("Mercedes" , "manuel" , "mavi" ,4, 2018, "4 çeker", "Park sensörü var");

            Ticari tic = new Ticari("Ford" , "otomatik" , "siyah" , 100, "4 çeker", 32);

            oto.Otomobilbilgiyaz();
            Console.WriteLine("\n");
            tic.TicariBilgiYaz();

            Console.ReadLine();
            
            
        }
    }
    class Arac
    {
        public string marka;

        public string vites;

        public string renk;     


    }

    class Otomobil 
    {

        public string marka;

        public string vites;

        public string renk;

        public int kapisayisi;

        public int model;

        public string ceker4;

        public string parksensoru;

        public Otomobil(string _marka, string _vites, string _renk , int _kapisayisi , int _model , string _ceker4 , string _parksensoru)
        {
            marka = _marka;
            vites = _vites;
            renk = _renk;
            kapisayisi = _kapisayisi;
            model = _model;
            ceker4 = _ceker4;
            parksensoru = _parksensoru;
        }

        public void Otomobilbilgiyaz()
        {
            Console.WriteLine("Otomobilin Markası = "+marka);
            Console.WriteLine("Kaç vites = "+vites);
            Console.WriteLine("Hangi Renk = "+renk);
            Console.WriteLine("Kaç tane kapısı var = "+kapisayisi);
            Console.WriteLine("Arabanın modeli = "+model);
            Console.WriteLine("4 Çeker mi = " + ceker4);
            Console.WriteLine("Park sensörü  var mı = "+parksensoru);
        }


    }

    class Ticari 
    {
        public string marka;

        public string vites;

        public string renk;

        public int tasimakapasitesi;

        public string ceker4;

        public int yolcukapasitesi;

        public Ticari(string _marka , string _vites , string _renk , int _tasimakapasitesi , string _ceker4 , int _yolcukapasitesi)
        {
            marka = _marka;
            vites = _vites;
            renk = _renk;
            tasimakapasitesi = _tasimakapasitesi;
            ceker4 = _ceker4;
            yolcukapasitesi = _yolcukapasitesi;
        }

       
        public void TicariBilgiYaz()
        {
            Console.WriteLine("Otomobilin Markası = " + marka);
            Console.WriteLine("Kaç vites = " + vites);
            Console.WriteLine("Hangi Renk = " + renk);
            Console.WriteLine("Taşıma kapasitesi kaç kg = kg"+tasimakapasitesi);
            Console.WriteLine("4 Çeker mi = "+ceker4);
            Console.WriteLine("Yolcu kapasitesi = "+yolcukapasitesi );
        }


    }
}
