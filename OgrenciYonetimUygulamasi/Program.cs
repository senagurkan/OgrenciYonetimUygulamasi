using System;
using System.Collections.Generic;

namespace OgrenciYonetimUygulamasi
{
    class Program
    {
        static List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        static void Main(string[] args)
        {
            SahteVeriGir();
            Uygulama();
        }

        static void Uygulama()
        {
            Menu(); while (true)
            {
                string secim = SecimAl();
                switch (secim)
                {
                    case "1":
                    case "E":
                        OgrenciEkle();
                        break;
                    case "2":
                    case "L":
                        OgrenciListele();
                        break;
                    case "3":
                    case "S":
                        OgrenciSil();
                        break;
                    case "4":
                    case "X":
                        return;
                    case "son":
                        return;
                }
                Console.WriteLine();
            }
        }
        static string SecimAl()
        {
            int sayac = 0;
            while (sayac < 10)
            {
                Console.Write("Seçiminiz: ");
                string giris = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (giris == "1" || giris == "E")
                {
                    return giris;
                }

                else if (giris == "2" || giris == "L")
                {
                    return giris;
                }
                else if (giris == "3" || giris == "S")
                {
                    return giris;
                }
                else if (giris == "4" || giris == "X")
                {
                    return giris;
                }
                else
                {
                    sayac++;
                    if (sayac < 10)
                        Console.WriteLine("Hatalı giriş Yapıldı.");
                }
            }
            string mesaj = "Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.";
            Console.WriteLine(mesaj);
            string sonlandir = "son";

            return sonlandir;

        }









        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması");
            Console.WriteLine("1 - Öğrenci Ekle (E)       ");
            Console.WriteLine("2 - Öğrenci Listele (L)    ");
            Console.WriteLine("3 - Öğrenci Sil (S)        ");
            Console.WriteLine("4 - Çıkış (X)              ");
            Console.WriteLine();
        }







        static void OgrenciEkle()
        {

            //buraya yeni bir öğrenci nesnesi açın
            Ogrenci o = new Ogrenci();
            Console.WriteLine("1- Öğrenci Ekle--------");
            Console.WriteLine();
            Console.WriteLine((Ogrenciler.Count + 1) + ". Öğrencinin");
            while (true)
            {
                Console.Write("No: ");
                int sayac = 0;
                o.No = int.Parse(Console.ReadLine());
                foreach (Ogrenci item in Ogrenciler)
                {
                    if (item.No == o.No)
                    {
                        sayac++;
                    }

                }

                if (sayac == 0)
                {
                    break;
                }

            }
            Console.Write("Adı: ");
            string ad = Console.ReadLine();
            o.Ad = ad.Substring(0, 1).ToUpper() + ad.Substring(1).ToLower();
            Console.Write("Soyadı: ");
            string soyad = Console.ReadLine();
            o.Soyad = soyad.Substring(0, 1).ToUpper() + soyad.Substring(1).ToLower();
            Console.Write("Şube: ");
            string sube = Console.ReadLine();
            o.Sube = sube.Substring(0, 1).ToUpper();
            Console.WriteLine();

            Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)");
            string secim = Console.ReadLine();
            Console.WriteLine();
            if (secim.ToUpper() == "E")
            {
                Ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }
        }
        static void OgrenciListele()
        {
            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Gösterilecek öğrenci yok.");
            }
            else
            {
                Console.WriteLine("2- Öğrenci Listele----------------");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Şube     No       Ad Soyad");
                Console.WriteLine("-----------------------------");
                foreach (Ogrenci item in Ogrenciler)
                {
                    Console.WriteLine(item.Sube.PadRight(9, ' ') + item.No + item.Ad.PadLeft(item.Ad.Length + 7, ' ') + item.Soyad.PadLeft(item.Soyad.Length + 1, ' '));
                }
            }


        }

        static void OgrenciSil()
        {
            Console.WriteLine("3- Öğrenci Sil ---------");
            int deger = Ogrenciler.Count;
            if (deger == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
            }
            else
            {
                Console.WriteLine("Silmek istediğiniz öğrencinin");
                Console.Write("No: ");
                int no = int.Parse(Console.ReadLine());
                Ogrenci ogr = null;
                foreach (Ogrenci item in Ogrenciler) //öğrenciyi bulmak için döngü var
                {
                    if (item.No == no)
                    {
                        ogr = item;
                        break;
                    }
                }
                if (ogr != null)
                {
                    Console.WriteLine("Adı: " + ogr.Ad);
                    Console.WriteLine("Soyadı: " + ogr.Soyad);
                    Console.WriteLine("Şubesi: " + ogr.Sube);
                    Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
                    string secim = Console.ReadLine();
                    if (secim.ToUpper() == "E")
                    {
                        Ogrenciler.Remove(ogr);
                        Console.WriteLine("Öğrenci silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci silinmedi.");
                    }
                }
                else
                {
                    Console.WriteLine("Böyle bir öğrenci bulunamadı.");
                }
            }

        }

        static void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci();
            o1.No = 12;
            o1.Ad = "Ayla";
            o1.Soyad = "Akın";
            o1.Sube = "A";
            Ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Burak";
            o2.Soyad = "Beyaz";
            o2.No = 45;
            o2.Sube = "B";
            Ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Neşe";
            o3.Soyad = "Can";
            o3.No = 23;
            o3.Sube = "B";
            Ogrenciler.Add(o3);

        }
    }
}
