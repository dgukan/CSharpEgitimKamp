using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler
            //string
            //Değişken_türü değişken_adı;
            //string name;
            //name = "Doğukan";
            //Console.Write(name);

            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city;

            //passengerName = "Ali";
            //passengerSurname = "Çınar";
            //passengerPhone = "+90 500 123 45 67";
            //passengerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezarvasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Müşteri: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("Email : " + passengerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("----------------------");
            #endregion

            #region Int Değişkenler
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Patetes Kızartması: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalcokePrice = 0;
            int totalwaterPrice = 0;
            int totalfriesPrice = 0;
            int totalpizzaPrice = 0;
            int totallemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("----------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalhamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı : " + totalcokePrice + " TL");
            Console.WriteLine("Su Tutarı : " + totalwaterPrice + " TL");
            Console.WriteLine("Patetes Kızartması Tutarı : " + totalfriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı : " + totalpizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı : " + totallemonadePrice + " TL");

            Console.WriteLine();
            int totalPrice = totalhamburgerPrice + totalcokePrice + totalwaterPrice + totalpizzaPrice + totallemonadePrice + totalfriesPrice;
            Console.WriteLine("Toplam Tutar : " + totalPrice + " TL");


            #endregion

            Console.Read();
        }
    }
}




//Yazdırma Komutları
