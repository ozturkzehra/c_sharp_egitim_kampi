using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_DERS2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Doubledegiskenler

            ////    double number;
            ////    number = 4.65; 
            ////    Console.WriteLine(number);
            ////    Console.ReadLine();
            //Console.WriteLine("**** Fiyat Liatesi ****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberyPrice, potato, tomato;

            //applePrice = 14.80;
            //orangePrice = 12.50;
            //strawberyPrice = 23.60;
            //potato = 43.80;
            //tomato =5.60;

            //Console.WriteLine("-----Elma birim fiyati :" + applePrice + "TL");
            //Console.WriteLine("-----Portakal birim fiyati : " + orangePrice + "TL");
            //Console.WriteLine("-----Çilek birim fiyati :" + strawberyPrice + "TL");
            //Console.WriteLine("-----Patates birim fiyati :" + potato + "TL");
            //Console.WriteLine("-----Domates birim fiyati :" + tomato + "TL");


            //double applegram = 1.245;
            //double orangegram = 4.444;
            //double strawberygram = 1.000; 
            //double potatogram = 2.456;
            //double tomatogram = 1.234;

            //double appleTotal = applePrice * applegram;
            //double orangeTotal = orangePrice * orangegram;
            //double strawberyTotal = strawberyPrice * strawberygram;
            //double potatoTotal = potato * potatogram;
            //double tomatoTotal = tomato * tomatogram;

            //double totalPrice = appleTotal + orangeTotal + strawberyTotal + potatoTotal + tomatoTotal;
            //Console.WriteLine();
            //Console.WriteLine("-----Toplam Tutar :" + totalPrice + "TL");


            #endregion



            #region Char degiskenler
            //char symnol;
            //symnol = 'a';
            //Console.WriteLine(symnol);

            #endregion



            #region Klavyeden Veri Girisi

            //Console.WriteLine("****Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentifyNumber;
            //Console.WriteLine("Yolcu Adını Giriniz: ");
            //passengerName = Console.ReadLine();

            //Console.WriteLine("Yolcu Soyadını Giriniz : ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("Yolcu İlini Giriniz : ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu İlçesini  Giriniz : ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Yolcu Yaşını  Giriniz : ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu Tc.Kimlik Numarasını   Giriniz : ");
            //passengerIdentifyNumber = Console.ReadLine();



            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu Bilgileri   " +"   Ad: "+ passengerName + "   Soyad: " + passengerSurname + "    Yas: " +passengerAge
            //    + "   İL: " + passengerCity+ "    ilce" + passengerDistrict +"   TC.KİMLİK: " + passengerIdentifyNumber );
            #endregion


            #region Klavyeden Tam Sayı Veri Girisi ve Dönüşümler

            //int shoePrice,computerPrice,chairPrice,tvPrice;
            //shoePrice = 1000;
            //chairPrice = 5000;
            //tvPrice = 10000;
            //computerPrice = 20000;

            //int shoesCount, computerCount, chairCount,tvCount;
            //Console.Write("lütfen aldıgınız AYAKABI adedi sayisini girimiz");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldıgınız BİLGİSAYAR adedi sayisini girimiz");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldıgınız SANDALYE adedi sayisini girimiz");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen aldıgınız TELEVİZYON adedi sayisini girimiz");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoePrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);
            //Console.Write("toplam price: " + totalPrice + "TL");

            #endregion

            #region Klavyeden Ondalıklı Sayi veri İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen birinci sınav notunuzu giriniz");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sınav notunuzu giriniz");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ucuncu sınav notunuzu giriniz");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sonucunuz :  " + result);


            //if(result > 40)
            //{
            //    Console.WriteLine("tebrıkler gectınız");

            //}
            //else if (result > 40 && result < 50)
            //{
            //    Console.WriteLine("kaldınız ama telafi sınavına girebilirsiniz");
            //}
            //else
            //{
            //    Console.WriteLine("kaldınız");
            //}

            #endregion


            #region Klavyeden karakter girişi

            char gender;
            Console.WriteLine("Lütfen cinsiyetinizi giriniz : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiiniz Cinsiyetiniz: " + gender);
            #endregion

            Console.Read();
        }
    }
}
