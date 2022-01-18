using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Bilgi_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Ilkokul> ilkokul = new List<Ilkokul>();
            List<Ortaokul> ortaokul = new List<Ortaokul>();
            List<Lise> lise = new List<Lise>();
            List<Universite> uni = new List<Universite>();
            while (true)
            {
                Console.WriteLine("*********** ÖĞRENCİ BİLGİ SİSTEMİ************");
                don:
                Console.WriteLine("1-Kayıt\n2-Listele\n3-Not Ortalama Hesapla\n4-Çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    while (true)
                    {

                        Console.WriteLine("İlkokul ==> 1\nOrtaokul ==> 2\nLise ==> 3\nÜniversite ==> 4\nAna Menü ==> 5");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        if (sec == 1)
                        {
                            Ilkokul io = new Ilkokul();
                            io.Kaydet(ilkokul);


                        }
                        else if (sec == 2)
                        {
                            Ortaokul oo=new Ortaokul();
                            oo.Kaydet(ortaokul);
                        }
                        else if (sec == 3)
                        {
                            Lise l = new Lise();
                            l.Kaydet(lise);
                        }
                        else if (sec == 4)
                        {
                            Universite univ=new Universite(); ;
                            univ.Kaydet(uni);
                        }
                        else if (sec==5)
                        {
                            goto don;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı İşlem");
                        }
                    }
                }
                else if (secim == 2)
                {
                    while (true)
                    {

                        Console.WriteLine("İlkokul ==> 1\nOrtaokul ==> 2\nLise ==> 3\nÜniversite ==> 4\nAna Menü ==> 5");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        if (sec == 1)
                        {
                            Ilkokul.Listele(ilkokul);


                        }
                        else if (sec == 2)
                        {
                            Ortaokul.Listele(ortaokul);

                        }
                        else if (sec == 3)
                        {
                            Lise.Listele(lise);

                        }
                        else if (sec == 4)
                        {
                            Universite.Listele(uni);

                        }
                        else if (sec == 5)
                        {
                            goto don;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı İşlem");
                        }
                    }

                }
                else if (secim == 3)
                {
                    while (true)
                    {

                        Console.WriteLine("İlkokul ==> 1\nOrtaokul ==> 2\nLise ==> 3\nÜniversite ==> 4\nAna Menü ==> 5");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        if (sec == 1)
                        {
                            Ilkokul io = new Ilkokul();
                            io.Not();
                            

                        }
                        else if (sec == 2)
                        {
                            Ortaokul oo = new Ortaokul();
                            oo.Not();

                        }
                        else if (sec == 3)
                        {

                            Lise l = new Lise();
                            l.Not();
                        }
                        else if (sec == 4)
                        {

                            Universite u = new Universite();
                            u.UniNot();
                        }
                        else if (sec == 5)
                        {
                            goto don;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı İşlem");
                        }
                    }
                }
                else if (secim == 4)
                {                   
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Hatalı İşlem!");
                }
            }
            
         
        }
    }
    public class Ogrenciler
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        

        protected void Kaydet()
        {
            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("No:");
            this.No = Convert.ToInt32(Console.ReadLine());
        }
        public double Not()
        {
            double ort = 0;
            Console.WriteLine("1.Notu Girin: ");
            double s1 = Convert.ToDouble(Console.ReadLine()); //1.Not
            Console.WriteLine("2.Notu Girin: ");
            double s2 = Convert.ToDouble(Console.ReadLine()); //2.Not
            ort = (s1 + s2) / 2;
            Console.WriteLine("Ortalama: " + ort);
            return ort;
        }
    }
    public class Ilkokul : Ogrenciler
    {
       public void Getir()
        {
            base.Not();
        }
        public new void Kaydet(List<Ilkokul> liste)
        {
            base.Kaydet();
            liste.Add(this);          
        }
        public static void Listele(List<Ilkokul> liste)
        {
            foreach (Ilkokul item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
               
            }
        }

    }
    public class Ortaokul : Ogrenciler
    {
        public void Getir()
        {
            base.Not();
        }
        public new void Kaydet(List<Ortaokul> liste)
        {
            base.Kaydet();
            liste.Add(this);
        }
        public static void Listele(List<Ortaokul> liste)
        {
            foreach (Ortaokul item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);

            }
        }
    }
    public class Lise : Ogrenciler
    {
        public void Getir()
        {
            base.Not();
        }
        public new void Kaydet(List<Lise> liste)
        {
            base.Kaydet();
            liste.Add(this);
        }
        public static void Listele(List<Lise> liste)
        {
            foreach (Lise item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);

            }
        }
    }
    public class Universite : Ogrenciler
    {
       
        public new void Kaydet(List<Universite> liste)
        {
            base.Kaydet();
            liste.Add(this);
        }
        public static void Listele(List<Universite> liste)
        {
            foreach (Universite item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);

            }
        }
        public double UniNot()
        {
            double ortalama = 0;
            Console.WriteLine("1.Notu Girin: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Notu ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            ortalama = ((s1 * .4) + (s2 * .6));
            Console.WriteLine("Ortalama: " + ortalama);
            return ortalama;

        }
    }



}
