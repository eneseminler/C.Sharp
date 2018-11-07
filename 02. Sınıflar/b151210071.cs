
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev02._1
{
   
    class musteri   //Müşteri bilgileri için sınıf
    {
        public static bool Kont_Uzun(string b)  //Müşteri nesnesinin bazı özellikleri için kontrol
        {
            if (b.Length == 11)   //Girilen string 11 hane mi kontrol
            {   return true; }   //Öyleyse doğru döner
            else
            {
                Console.WriteLine("-11 Hane girmeniz gerekir!\n-Tekrar giriniz.");
                return false;   //Doğru değilse yanlış döner
            }
        }
        private string musteri_Ad, musteri_Adres, musteri_Tel, musteri_Faks, musteri_Mail, musteri_Web, musteri_Ver, musteri_Tar;  //Müşterinin nesnesimim özellikleri
       
        public void musteri_ekle()    //Yeni bir müşteri nesnesi oluşturmak için fonksiyon
        {
            //Nesne özelliklerini kullanıcıdan alıyoruz
            Console.Write("Müşteri Adı: ");   
            Musteri_Ad = Console.ReadLine();
            Console.Write("Müşteri Adresi: ");
            Musteri_Adres = Console.ReadLine();
            //Özelliklerin doğruluğu için kontrol
            do
            {
                Console.Write("Müşteri Telefon numarası<11 hane> : ");
                Musteri_Tel = Console.ReadLine();
            } while (Kont_Uzun(Musteri_Tel) == false);
            //Özelliklerin doğruluğu için kontrol
            do
            {
                Console.Write("Müşteri Faks numarası: ");
                Musteri_Faks = Console.ReadLine();
            } while (Kont_Uzun(Musteri_Faks)==false);

            Console.Write("Müşteri Mail adresi: ");
            Musteri_Mail = Console.ReadLine();

            Console.Write("Müşteri web sitesi: ");
            Musteri_Web = Console.ReadLine();
            //Özelliklerin doğruluğu için kontrol
            do
            {
                Console.Write("Müşteri Vergi numarası: ");
                Musteri_Ver = Console.ReadLine();
            } while (Kont_Uzun(Musteri_Ver)==false);

            Console.Write("Müşteri son sipariş tarihi: ");
            Musteri_Tar = Console.ReadLine();
        }
        //private değişkenler için köprü
        public string Musteri_Ad  
        {
            get { return musteri_Ad; }
            set { musteri_Ad = value; }
        }
        public string Musteri_Adres
        {
            get { return musteri_Adres; }
            set { musteri_Adres = value; }
        }
        public string Musteri_Tel
        {
            get { return musteri_Tel; }
            set { musteri_Tel = value; }
        }
        public string Musteri_Faks
        {
            get { return musteri_Tel; }
            set { musteri_Tel = value; }
        }
        public string Musteri_Mail
        {
            get { return musteri_Mail; }
            set { musteri_Mail = value; }
        }
        public string Musteri_Web
        {
            get { return musteri_Web; }
            set { musteri_Web = value; }
        }
        public string Musteri_Ver
        {
            get { return musteri_Ver; }
            set { musteri_Ver = value; }
        }
        public string Musteri_Tar
        {
            get { return musteri_Tar; }
            set { musteri_Tar = value; }
        }
        //public void musteri_goster()
        //{
        //    Console.Write("\n...---~~~~Bilgiler~~~~---...\n");
        //    Console.WriteLine("Müşteri Adı: " + musteri_Ad);
        //    Console.WriteLine("Müşteri Adresi: " + musteri_Adres);
        //    Console.WriteLine("Müşteri Telefon numarası: " + musteri_Tel);          //nesneyi ekrana yazdıran fonksiyon
        //    Console.WriteLine("Müşteri Faks numarası: " + musteri_Faks);
        //    Console.WriteLine("Müşteri Mail adresi: " + musteri_Mail);
        //    Console.WriteLine("Müşteri web sitesi: " + musteri_Web);
        //    Console.WriteLine("Müşteri Vergi numarası: " + musteri_Ver);
        //    Console.WriteLine("Müşteri son sipariş tarihi: " + musteri_Tar);
        // }
    }
    class katı:musteri                                //Katı cisminin sınıfı
    {
        private string katı_Adı;                      //Katı nesnesinin özellikleri
        private int katı_Ton, katı_Hac;
        public void katı_ekle(int mesafee)             //Katı nesnesi oluşturma fonksiyonu
        {                                              //Parametre olarak taşınacak mesafe alındı
            Console.Write("Katı ürünün adı: ");        
            Katı_Adı = Console.ReadLine();
            Console.Write("Katı ürünün tonajı: ");
            Katı_Ton = Convert.ToInt32(Console.ReadLine());
            Console.Write("Katı ürünün paket hacmi: ");
            Katı_Hac = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n***********************************************");      // Katı cisim taşıma ücreti hesaplanıyor
            double katı_ucret = (Katı_Ton * mesafee * 1) + 1000;
            Console.WriteLine("Toplam tutar: " + katı_ucret);
        }
        public string Katı_Adı                //Katı nesnesinin private değişkenleri için köprü
        {
            get { return katı_Adı; }
            set { katı_Adı = value; }
        }
        public int Katı_Ton
        {
            get { return katı_Ton; }
            set { katı_Ton = value; }
        }
        public int Katı_Hac
        {
            get { return katı_Hac; }
            set { katı_Hac = value; }
        }
    }
    class sıvı:musteri           //Sıvı sınıfı
    {
        private string sıvı_Adı;           //Sıvı bir nesnenin sahip olduğu özlleri
        private int sıvı_Ton, sıvı_Agır;
        public void sıvı_ekle(int mesafee) //Parametresi ürünün taşınacağı mesafe
        {
           
            Console.Write("Sıvı ürünün adı: ");
            Sıvı_Adı = Console.ReadLine();
            Console.Write("Sıvı ürünün tonajı: ");
            Sıvı_Ton = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sıvı ürünün özgül ağırlığı: ");
            Sıvı_Agır = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n***********************************************");
            double sıvı_ucret = Sıvı_Ton * mesafee * 1.25;              //Ücret hesaplandı, parametre kullanıldı
            Console.WriteLine("Toplam tutar: " + sıvı_ucret);
         }
        //Sıvının private değişkenleri için köprü
        public string Sıvı_Adı
        {
            get { return sıvı_Adı; }
            set { sıvı_Adı = value; }
        }
        public int Sıvı_Ton
        {
            get { return sıvı_Ton; }
            set { sıvı_Ton = value; }
        }
        public int Sıvı_Agır
        {
            get { return sıvı_Agır; }
            set { sıvı_Agır = value; }
        }
    }
    class gaz:musteri     //Gaz maddesi için sınıf oluşturuldu
    {
        private string gaz_Adı, gaz_Tipi;  //Gaz nesnesini özellikleri
        private int gaz_Hac;
        public void gaz_ekle(int mesafee)   //Gaz nesnesi oluşturulmak için fonksiyon
        {
          
            Console.Write("Gaz ürünün adı: ");
            Gaz_Adı = Console.ReadLine();
            Console.Write("Gaz ürünün hacmi: ");
            Gaz_Hac = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gaz ürünün tipi: ");
            Gaz_Tipi = Console.ReadLine();


            Console.WriteLine("\n***********************************************");
            double gaz_ucret = (Gaz_Hac * mesafee * 1.1) + 4000;   //Ücret hesaplandı, mesafe parametre olarak alındı
            Console.WriteLine("Toplam tutar: " + gaz_ucret);
        }

        //Gaz nesnesinin private özellikleri için köprü
        public string Gaz_Adı
        {
            get { return gaz_Adı; }
            set { gaz_Adı = value; }
        }
        public string Gaz_Tipi
        {
            get { return gaz_Tipi; }
            set { gaz_Tipi = value; }
        }
        public int Gaz_Hac
        {
            get { return gaz_Hac; }
            set { gaz_Hac = value; }
        }
    }
    class deger:musteri       //Değerli ürünün sınıfı
    {
        private string deger_Adı;   //Değerli ürün nesnesini özellikleri
        private int deger_Hac, deger_Ton, deger_Adet, deger_Agır;
        public void deger_ekle(int mesafee)              //Değerli ürün nesnesi oluşturma fonksiyonu
        {
           
            Console.Write("Değerli ürünün adı: ");
            Deger_Adı = Console.ReadLine();
            Console.Write("Değerli ürünün hacmi: ");
            Deger_Hac = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün tonajı: ");
            Deger_Ton = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün adedi: ");
            Deger_Adet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün adet ağırlığı: ");
            Deger_Agır = Convert.ToInt32(Console.ReadLine());
                       
            Console.WriteLine("\n***********************************************");
            //Ücret değerli ürünün ağırlık hacim oranına göre belirleniyor
            if(deger_Ton/deger_Hac >= 0.5)
            {
                double deger_ucret = ((Deger_Ton * 1.5) + (Deger_Hac * 1.5)) / 2 + (mesafee * 1.5);
                Console.WriteLine("Toplam tutar: " + deger_ucret);                        //Ücret hesaplandı ekrana yazdırıldı, mesafe parametre olarak alındı
            }
            else
            {
                double deger_ucret = Deger_Hac * 1.5 + (mesafee * 2);
                Console.WriteLine("Toplam tutar: " + deger_ucret);                        //Ücret hesaplandı ekrana yazdırıldı
            }             
        }
        //Değerli ürün nesnesinin private özellikleri için köprü
        public string Deger_Adı
        {
            get { return deger_Adı; }
            set { deger_Adı = value; }
        }
        public int Deger_Hac
        {
            get { return deger_Hac; }
            set { deger_Hac = value; }
        }
        public int Deger_Ton
        {
            get { return deger_Ton; }
            set { deger_Ton = value; }
        }
        public int Deger_Adet
        {
            get { return deger_Adet; }
            set { deger_Adet = value; }
        }
        public int Deger_Agır
        {
            get { return deger_Agır; }
            set { deger_Agır = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();    //Müşteri nesnesine bellekte referans oluşturuldu
            musteri1.musteri_ekle();             //Müşteri ekleme fonksiyonu ile nesne oluşturuldu
                                                 //musteri1.musteri_goster();         //Kullanılırsa nesneyi ekrana yazdırıyor


            int Mesafe;                                      //Ücret hesaplanırken kullanılacak mesafe değişkeni
            Console.Write("Taşınacak mesafeyi girin: ");
            Mesafe = Convert.ToInt32(Console.ReadLine());    //Mesafe kullanıcıdan alındı
            string urun;             
            int urunsayı;
            do         //Seçim menüsünün döngüsü
            {
                Console.Write("Taşınacak ürün nedir? (0:Sıvı, 1:Katı, 2:Gaz, 3:Değerli ürün) : ");
                urun = Console.ReadLine();        //Hangi ürünün seçildiğini alıyoruz
                urunsayı = Convert.ToInt32(urun); //Ürün kodunu tamsayıya değiştiriyoruz
              
                switch (urun)              //Seçim yapılıyor koduna göre
                {
                    case "0":  //Sıvı seçeneği 
                        sıvı sıvı1 = new sıvı();       
                        sıvı1.sıvı_ekle(Mesafe);   //Sıvı nesnesi oluşturulması için fonk çağırılıyor
                        break;
                    case "1":  //Katı seçeneği
                        katı katı1 = new katı();   
                        katı1.katı_ekle(Mesafe);    //Katı nesnesi oluşturulması için fonk çağırılıyor
                        break;
                    case "2":  //Gaz seçeneği
                        gaz gaz1 = new gaz();
                        gaz1.gaz_ekle(Mesafe);      //Gaz nesnesi oluşturulması için fonk çağırılıyor
                        break;
                    case "3":  //Değerli ürün seçeneği
                        deger deger1 = new deger();
                        deger1.deger_ekle(Mesafe);    //Değerli ürün nesnesi oluşturulması için fonk çağırılıyor
                        break;
                    default:
                        Console.WriteLine("Böyle bir ürün kodu yoktur...");
                        break;                          //Eğer listede olmayan seçenek aranırsa
                }
            } while (urunsayı > 3 || urunsayı < 0);     //Listedeki bir tip belirtilene kadar döner
            Console.ReadKey();   //Program sonu
        }
    }
}
