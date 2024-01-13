using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciYonetimUygulamasi
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public string Sube;
        public int No;
        public int DogumYili;
        public int Yas;

        public int MatematikNotu;
        public int TürkçeNotu;
        public int FenNotu;
        public int SosyalNotu;


        public Ogrenci()
        {
            Console.WriteLine("Öğrenci oluşturuldu.");
        }

        public Ogrenci(int no, string ad, string soyad)
        {
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            Console.WriteLine("Öğrenci oluşturuldu.Bilgiler eklendi");
        }

        // bu sınıfta ekrana yazı yazdırma işi yapma yı tercih etmeyiz.
        public void OrtalamaYazdir()
        {
            int toplam = MatematikNotu + TürkçeNotu + FenNotu + SosyalNotu;
            float ortalama = (float)toplam / 4;

            Console.WriteLine(No + " nolu öğrencinin ortalaması : " + ortalama);

        }

        public float OrtalamaGetir()
        {
            int toplam = MatematikNotu + TürkçeNotu + FenNotu + SosyalNotu;
            float ortalama = (float)toplam / 4;

            return ortalama;
        }


        public void YasHesapla()
        {
            Yas = 2023 - DogumYili;
        }

        public int YasHesapla(int yil)
        {
            return 2023 - yil;
        }

    }
}
