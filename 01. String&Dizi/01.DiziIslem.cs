


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpodev1
{
    class Program
    {    
        static void Main(string[] args)
        {
            int val = -2;    //Başlangıçta döngüyü kontrol eden değişkene yanlış değer atıyorum

            while (val < 0)  //Döngü başlangıcı ve değer pozitif olduğu sürece devam edicek
            {
                Console.Write("Dizinin indeks değerini giriniz. :");
                val = Convert.ToInt32(Console.ReadLine());  //Dizinin kaç elemanı olacağını atıyoruz

                if(val<0) //Eleman sayısı tabiki pozitif olmalı
                {
                    Console.WriteLine("Lütfen pozitif bir indeks değeri giriniz!");
                }
            }

            int[] array = new int[val];  //Dizi oluşturuluyor

            for (int i = 0; i < val; i++)     //Dizi elemanları alınıyor
            {
                Console.Write(" {0}. değeri giriniz :", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine()); //Elemanlar atanıyor
            }

            Console.Write("Dizi elemanları: ");
            for (int i = 0; i < val; i++)              //Elemanlar ekrana yazdırılıyor
            {
                Console.Write(array[i] + "\t");
            }

            int ind_1 = -5, ind_2 = -5;                 //Aralık değerleri tanınıyor
            while ((ind_1 < 0 || ind_1 > val-1) && (ind_2 < 0 || ind_2 > val)) //Aralıkların alabileceği değerler
            {
                Console.WriteLine("\nAralık değerlerini veriniz<2 tane> : ");

                Console.Write("Birinci değeri giriniz: ");
                ind_1 = Convert.ToInt32(Console.ReadLine());
                if (ind_1 < 0 || ind_1 > val-1)     //İlk aralık değeri kontrol ediliyor
                {
                    Console.WriteLine("Yanlış değer girdiniz. Doğru aralıkta değer giriniz. < 0 " + (val-1) + ">");
                }

                Console.Write("İkinci değeri giriniz: ");
                ind_2 = Convert.ToInt32(Console.ReadLine());
                if (ind_2 < 0 || ind_2 > val)           //İkinci değer kontrol ediliyor
                {
                    Console.WriteLine("Yanlış değer girdiniz. Doğru aralıkta değer giriniz. < 0 " + val + ">");
                }
            }

            int toplam1 = 0;
            for (int i = 0; i < ind_1; i++)     //Birinci aralık toplamı yapılıyor ilk indisten ilk aralık değerine kadar
            {
                toplam1 += array[i];
            }

            int toplam2 = 0;
            for (int i = ind_1; i <= ind_2; i++) //İkinci aralık toplamı yapılıyor ilk aralık değerinden ikinci aralık değerine kadar
            {
                toplam2 += array[i];
            }

            int toplam3 = 0;
            for (int i = ind_2; i+1 < val; i++) //Üçüncü aralık toplamı yapılıyor ikinci aralık değerinden son indise kadar
            {
                toplam3 += array[i];
            }

            Console.WriteLine("1. aralık değeri ="+ toplam1);  //Toplam değerleri ekrana yazdırılıyor
            Console.WriteLine("2. aralık değeri ="+ toplam2);
            Console.WriteLine("3. aralık değeri ="+ toplam3);
            
            //Program sonu
        }
    }
}
