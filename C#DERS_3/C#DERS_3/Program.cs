using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DERS_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region If Else
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yalnış");
            //}
            //#endregion


            //string capital, country;
            //Console.WriteLine("Başkenti giriniz");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();


            //if(capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("veriler dogrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatali veri");
            //}

            //int number;
            //Console.WriteLine("lütfen bi sayı gırınız");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayi dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi hatali");
            //}

            //int exam1, exam2, exam3, average;
            //string result;

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("sınavların ortalaması : " + average);
            //Console.Read();

            //int sayi1, sayi2;
            //Console.Write("lütfen bırıncı sasyıyı gırınız");
            //sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayiyi giriniz");
            //sayi2 = int.Parse(Console.ReadLine());

            //int result = sayi1 % sayi2;
            //Console.Write(result);

            //#region switch case
            //Console.Write("Lütfen ay girişinizi yapın");

            //int monthNumber = int.Parse(Console.ReadLine());


            //        switch(monthNumber)
            //        {
            //            case 1: Console.WriteLine("Ocak");break;
            //            case 2: Console.WriteLine("Şubat");break;
            //            case 3: Console.WriteLine("Mart");break;
            //            case 4: Console.WriteLine("Nisan");break;
            //            case 5: Console.WriteLine("Mayıs");break;
            //            case 6: Console.WriteLine("Haziran");break;
            //            case 7: Console.WriteLine("Temmuz");break;
            //            case 8: Console.WriteLine("Ağustos");break;
            //            case 9: Console.WriteLine("Eylül");break;
            //            case 10: Console.WriteLine("Ekim");break;
            //            case 11: Console.WriteLine("Kasım");break;
            //            case 12: Console.WriteLine("Aralık");break;
            //            default: Console.Write("hatalı veri girişi");break;
            //        }

            //#endregion

            #region Switch-Case hesap makinesi 
            int number1, number2, result;
            char isaret;


            Console.WriteLine("Lüttfen ilk sayiyi gitiniz");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayiyi giriniz");
            number2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            isaret = char.Parse(Console.ReadLine());

          
            switch(isaret)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("The Result is : " + result);break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("The Result is : " + result);break;
                case '*':
                    result = number1  * number2;
                    Console.WriteLine("The Result is : " + result);break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("The Result is : " + result);break;
                default:
                    Console.WriteLine("Hatalı sayi veya işlem girdiniz");break;
            }

            #endregion






            Console.Read();




        }
    }
}
