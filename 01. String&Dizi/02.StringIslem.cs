/****************************************************************************
**                         SAKARYA ÜNİVERSİTESİ
**               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ 
**                NESNEYE DAYALI PROGRAMLAMA DERSİ 
**                     2015-2016 BAHAR DÖNEMİ 
** 
**            ÖDEV NUMARASI..........: 1
**            ÖĞRENCİ ADI............: Enes Eminler
**            ÖĞRENCİ NUMARASI.......: b151210071
**            DERSİN ALINDIĞI GRUP...: B Grubu
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharpodev1._2
{

    class Program
    {
        public static bool Kontrol(string kont)                 //Menüye girilen seçimin sayı olup olmadığını kontrol eden fonksiyon
        {
           
            int hedef_degisken = 0;
            if (int.TryParse(kont, out hedef_degisken))
            {
               
                if (hedef_degisken < 5 || hedef_degisken > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (hedef_degisken > 4 || hedef_degisken < 1)
                {
                    Console.WriteLine("Yanlış değer girdiniz.\n");
                    return true;
                }

                else
                    return false;
            }

        }

        static void Main(string[] args)
        {
            string secenek;  //Menünün seçim seçeneğinin atandığı seçenek   
            do               //Menünün döngü başlangıç yeri
            {
                
                Console.WriteLine(".........-------~~~~~~~~ Menü ~~~~~~~~---------.........");
                Console.WriteLine("1- String bir değişkende, string değeri substring kullanmadan ara.");
                Console.WriteLine("2- String bir değişkende, string değeri substring kullanarak ara.");
                Console.WriteLine("3- Alfabenin karakterlerini bir string de ara, kaç kez geçiyor bul ve çiz.");
                Console.WriteLine("4- Çıkış");
                Console.Write("Seçiminiz : ");
                secenek = Console.ReadLine();


                int kontrol_1 = 0;
                int.TryParse(secenek, out kontrol_1);
                if (kontrol_1 < 0 || kontrol_1 > 5)  //Sayının büyük ya da küçük olması kontrolü
                {
                    Console.WriteLine("Yanlış değer girdiniz.<0,4> \n");
                }

                switch (secenek)            //Menüdeki seçenekler başlangıcı
                {
                    case "1":               //Substringsiz arama 

                        Console.Clear();

                        Console.Write("Karakter dizisini(cümlenizi) giriniz: ");
                        string str_ara = Console.ReadLine();                  //İçinde arama yapılacak dizi alınıyor.

                        Console.Write("Aradığınız karakterleri giriniz: ");
                        string aranan = (Console.ReadLine());                 //Aranacak dizi alınıyor.

                        int yanlıs = 0;

                        for (int i = 0; i < str_ara.Length-1; i++)              //Arama yapılacak dizinin her karakteri için kontrol
                        {
                            for (int a = 0; a < aranan.Length-1; a++)           //Aranacak diziyi tek tek ele alıyoruz.
                            {
                                if (str_ara[i] != aranan[a])                  //   Eğer eşit değilse 1 artıyor. Yanlış sayısı
                                {                                             //aranacak dizi sayısına gelirse dizide yoktur.
                                    yanlıs++;
                                } 
                                if (str_ara[i] == aranan[a])                   //Aranan karakterlerin ilki eşit ise doğrusu
                                {
                                    if (str_ara[i+1] == aranan[a+1])           //Bir sonraki karakteri de kontrol ettiriyorum
                                    {
                                        Console.WriteLine(i + 1 + ". indiste var ~ " + aranan + " ~"); //Doğruysa ekrana yazdırıyor
                                    }
                                }
                                else
                                { 
                                    break;                                     //Doğru değilse çıkıyor
                                }
                               
                            }
                        }

                        if (yanlıs==str_ara.Length)             //Yanlış değişkeni aranacak dizi sayısına eşit ise yok demektir
                        {
                            Console.WriteLine("\nAradığınız karakterler bu dizinde yok\n");
                        }
                        break;
                    case "2":         //Substring ile arama
                        Console.Clear(); //Ekran temizleniyor

                        Console.Write("Karakter dizini: ");
                        string str_aranacak = Console.ReadLine();        //İçinde arama yapılacak dizi alınıyor

                        Console.Write("Aradığınız karakterleri giriniz: ");
                        string ara = Console.ReadLine();                 //Aranacak dizi alınıyor

                        int arama = Convert.ToInt32(ara.Length);         //Aranacak dizinin boyu atanıyor
                        int yok = 0;
                        for (int i = 0; i < str_aranacak.Length - arama + 1; i++)     //Döndü içinde arama yapılacak dizi kadar dönülüyor, aranacak dizi çıkartılıyor.
                        {                                                             //Eğer aranacak çıkartılmazsa dizi boyutu hatası alınır
                            string yeni = str_aranacak.Substring(i, arama);           //Dizi, aranacak dizinin boyu kadar parçalanıyor
                             
                            if (yeni == ara)                   //Eğer bu parçalar aranacak dizi ile aynıysa doğrudur
                            {
                                Console.WriteLine((i + 1) + ". indiste var ~ " + yeni + " ~");
                            }
                            else                               //Aynı değilse 
                            {
                                yok += +1;                     //değişken 1 artıyor
                            }
                        }
                        if (yok == str_aranacak.Length)       //Eğer değişken aranacak dizi kadar artarsa içinde yok demektir.
                        {
                            Console.WriteLine("\nAradığınız karakterler bu dizinde yok\n");
                        }
                        break;

                    case "3":       //Harf sayacı ve Yıldızlı grafik
                        Console.Clear(); //Ekran temizliği

                        //string str  = "Şu boğaz harbi nedir? Varmı ki dünyada eşi?En keşif orduların yükleniyor dördü beşi Tepeden yol bularak geçmek için Marmara'ya Kaç donanmayla sarılmış ufacık bir karaya.";
                        Console.Write("String ifadenizi giriniz: "); 
                        string str = Console.ReadLine();         //Harfleri sayılacak dizi alınıyor

                        int[] sayac = new int[32];               //Her harfin kaç tane olduğunu hafızada tutacak dizi
                        char[] alfabe = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'Q', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V','W','X', 'Y', 'Z' };
                            //Harfleri saydığımız alfabe
                        string strbuyuk = str.ToUpper(); //Karışıklık olmaması için tüm harfleri büyültüyorum

                        for (int i = 0; i < strbuyuk.Length; i++) //Döngü dizinin uzunluğu kadar dönüyor
                        {
                            for (int a = 0; a < 32; a++)          //Her karakter için harf sayımız kadar dönüyoruz
                            {
                                if (strbuyuk[i] == alfabe[a])     //Eğer 5. sırada eşitse D harfidir
                                {
                                    sayac[a] += +1;               //5. indise 1 eklenir...
                                }
                            }
                        }
                   
                        for (int i = 0; i < 32; i++)              //Tüm harfleri ve değerlerini yazmak için 32 ye kadar
                        {
                            Console.Write((alfabe[i]) + ": " + sayac[i] + " : "); //Hem harfi hem de kaç adet olduğunu yazdırıyorum
                            for (int a = 0; a < sayac[i]; a++)                    //Harfin adeti kadar yıldız koyuluyor
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n"); //Yıldızlar bitince satır atlar
                        }
                      break;
                        
                    case "4": //Çıkış seçeneği
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (Kontrol(secenek)); //Menünün döngü sonu

        }
    }
}
