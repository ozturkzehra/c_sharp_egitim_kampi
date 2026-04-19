using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_DERSİ1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("selam");
            Console.WriteLine("merhaba Dünya");
            Console.WriteLine("***Yemek kategorileri***");
            Console.WriteLine();
            Console.WriteLine("-ÇORBALAR");
            Console.WriteLine("-ANA YEMEKLER");
            Console.WriteLine("-TATLILAR");

            #region string yapilari

            string customerName;
            string customerSurName;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Zehra";
            customerSurName = "ozturk";
            customerPhone = "1234567890";
            customerEmail = "oztuekzehra@gmail.com";
            district = "kadikoy";
            city = "istanbul";

            Console.WriteLine("**** Rezervasyon karti ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Müsteri: " + customerName + " " + customerSurName + " " + customerPhone + " " + customerEmail + " " + district + " " + city);
            #endregion

            #region int yapilari
            int
            int hamburgerPrice = 300;
            int ayranPrice = 35;
            int waterPrice = 10;
            int friesPrice = 60;
            Console.WriteLine("**** Restoran Menü Fiyati ****");
            Console.WriteLine();
            Console.WriteLine("----- Ayran :" + ayranPrice + " TL");
            Console.WriteLine("----- Hamburger :" + hamburgerPrice + " TL");
            Console.WriteLine("----- Su :" + waterPrice + " TL");
            Console.WriteLine("----- Patates :" + friesPrice + " TL");

            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyati ****");


            int hamburgerCount = 3;
            int waterCount = 2;
            int ayranCount = 1;
            int friesCount = 1;


            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalAyranPrice = ayranPrice * ayranCount;
            int totalFriesPrice = friesPrice * friesCount;

            Console.WriteLine("Hamburger total fiyat : " + totalHamburgerPrice);
            Console.WriteLine("Ayran total fiyat : " + totalAyranPrice);
            Console.WriteLine("Water total fiyat : " + totalWaterPrice);
            Console.WriteLine("Fries total fiyat : " + totalFriesPrice);

            float TotalPrice = totalHamburgerPrice + totalWaterPrice + totalAyranPrice + totalFriesPrice;
            Console.WriteLine();
            Console.WriteLine("Total toplam FİYAT:" + TotalPrice + "TL");


            Console.WriteLine("-------------------------------------");

            #endregion

#region ornek deneme
            String Yonetici;
            String Musteri;
            String Ogrenci;


            Yonetici = "Ali";
            Musteri = "Zehra";
            Ogrenci = "Fatma";


            String Mudurinfo = " İsim: " + Yonetici;
            String Yoneticiinfo = " İsim: " + Musteri;
            String Ogrencinfo = " İsim: " + Ogrenci;

            Console.WriteLine(Mudurinfo + Yoneticiinfo + Ogrencinfo);

            #endregion


             




            Console.Read();


        }
    }
}
