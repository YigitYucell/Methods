
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            /* int _result = Addition();
             Console.WriteLine(_result);                     //1-Geriye Değer Döndüren ve Parametre Almayan Metotlar
             Console.ReadLine();*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* Console.WriteLine("Bir sayı giriniz: ");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Bir sayı giriniz: ");
             int b = Convert.ToInt32(Console.ReadLine());            //2-Geriye Değer Döndüren ve Parametre Alan Metotlar
             int mult = Multiply(a, b);
             Console.WriteLine(mult);
             Console.ReadLine();*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* Calculate();
             Console.ReadLine();*/                           //3-Geriye Değer Döndürmeyen ve Parametre Almayan Metotlar
                                                             //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenarı girin :");           //4-Geriye Değer Döndürmeyen ve Parametre Alan Metotlar
            int uk = Convert.ToInt32(Console.ReadLine());
            Calculate(kk, uk);
            Console.ReadLine();*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Console.WriteLine("Bir Sayı Girin");
            int sayi = Convert.ToInt32(Console.ReadLine());     // 1-Metot örnek 
            tekmiciftmi(sayi);
            Console.ReadLine();*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = Asalmi(sayi);
            if (sonuc == 0)
            {
                Console.WriteLine("{0} Asal Sayı Değildir.", sayi); // 2-Metot örnek
            }
            else
            {
                Console.WriteLine("{0} Asal Sayıdır.", sayi);
            }
            Console.ReadLine();*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Console.Write("1. Yazılıyı Girin: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Yazılıyı Girin: ");               3-Metot örnek
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Average(y1, y2));
            Console.ReadLine();*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* private static int Addition()
         {
             int a;
             int b;                                          //1-Geriye Değer Döndüren ve Parametre Almayan Metotlar
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
             int result = a + b;
             return result;
         }*/
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*static int Multiply(int a, int b)
        {
            int result = a * b;                             //2-Geriye Değer Döndüren ve Parametre Alan Metotlar
            return result;
        }*/
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*private static void Calculate()
        {
            Console.Write("Kısa kenarı girin :");
            int kk = Convert.ToInt32(Console.ReadLine());       //3-Geriye Değer Döndürmeyen ve Parametre Almayan Metot 
            Console.Write("Uzun kenarı girin :");
            int uk = Convert.ToInt32(Console.ReadLine());
            int area = kk * uk;
            Console.WriteLine("Alan = {0}", area);
        }*/
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*private static void Calculate(int shortEdge , int longEdge)
        {
            int area = shortEdge * longEdge;
            Console.WriteLine("Area = {0}", area);              //4-Geriye Değer Döndürmeyen ve Parametre Alan Metot

        }*/

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /* static void tekmiciftmi(int a)
         {
             if (a % 2 == 0)
             {
                 Console.WriteLine("Sayı Çift");               //  1-Metot örnek 
             }
             else
             {
                 Console.WriteLine("Sayı Tek");
             }
         }*/
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*private static int Asalmi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)      //2-Metot örnek
                {
                    return 0;
                }
            }
            if (i == sayi)
            {
                return 1;
            }
            return 0;
        }*/
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*public static string Average(double n1, double n2)
        {
            string s;
            if ((n1 + n2) / 2 >= 50)
            {
                s = "Geçti";            3-Metot örnek
            }
            else
            {
                s = "Kaldı";
            }
            return s;*/
        }

    }
}