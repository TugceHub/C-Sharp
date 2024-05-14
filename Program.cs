// Sınıflar ve Nesneler
// Nesne Nedir?
//    SınıfAdı NesneAdı = new SınıfAdı();

// Uygulama: Araba Sınıfı

using sınıflarVeNesneler;
using System.Runtime.InteropServices;

//class program
//{
//    static void Main(string[] args)
//    {
//        Araba ar = new Araba();
//        ar.marka = "ferrai";
//        ar.hiz = 200;
//        ar.renk = "lacivert";
//        ar.motor = 2.0;

//        Müşteri mu = new Müşteri();
//        mu.id = 1881;
//        mu.name = "Fatma ";
//        mu.surname = "BULUT";
//        mu.city = "Ankara";

//        Console.WriteLine("*********** ARABA TANTIM KARTI 1 ************");
//        Console.WriteLine();
//        Console.WriteLine("Marka : " + ar.marka);
//        Console.WriteLine("Hız : " + ar.hiz);
//        Console.WriteLine("Renk : " + ar.renk);
//        Console.WriteLine("Motor : " + ar.motor);

//        Console.WriteLine("*********** Müşteri Bilgisi ************");
//        Console.WriteLine();
//        Console.WriteLine("Ad Soyad : " + mu.id +" - "+ mu.name + mu.surname);
//        Console.WriteLine("Şehir : " + mu.city);
//        Console.WriteLine();
//        Console.WriteLine();

//        mu.id = 1938;
//        mu.name = "Beyza Basak ";
//        mu.surname = "BULUT";
//        mu.city = "Ankara";
//        Console.WriteLine("Ad Soyad : " + mu.id + " - " + mu.name + mu.surname);
//        Console.WriteLine("Şehir : " + mu.city);

//    }

//}

//Sınıf İçindeki Niteliklere Klavyeden Değer Girişi

//class Program
//{
//    static void Main(String[] args)
//    {
//        Müşteri m = new Müşteri();

//        Console.WriteLine("ID : ");
//        m.id = Convert.ToInt16(Console.ReadLine()); // int olduğu için convertledik

//        Console.WriteLine("AD : ");
//        m.name = Console.ReadLine();

//        Console.WriteLine("SOYAD : ");
//        m.surname = Console.ReadLine();

//        Console.WriteLine("Şehir : ");
//        m.city = Console.ReadLine();
//    }
//}

// Kapsülleme Nedir?
/*
 * Nesnelerin niteliklerinin bilinçsiz kullanımını önlemek.
 * İlgili özelliklerin istenilen değer ya da aralıkta olmasını sağlamak.
 * Değişkenlere direkt erişimin önüne geçmek.
 * Arka planda kodları gizlemek.
 *** Anahtar kelime: property
 */

//Kapsülleme Örneği

//class Program
//{
//    static void Main(String[] args)
//    {
//        Müşteri m = new Müşteri();

//        Console.WriteLine("ID : ");
//        m.id = Convert.ToInt16(Console.ReadLine()); // int olduğu için convertledik

//        Console.WriteLine("AD : ");
//        m.Name = Console.ReadLine();

//        Console.WriteLine("SOYAD : ");
//        m.Surname = Console.ReadLine();

//        Console.WriteLine("Şehir : ");
//        m.city = Console.ReadLine();

//        Console.WriteLine("************* MÜŞTERİ BİLGİSİ ********************");
//        Console.WriteLine(" ");
//        Console.WriteLine("Kayıt BAŞARILI : "+ m.id+" - " +m.Name+" " + m.Surname+" " + m.city );
//    }   

//}

// KALITIM NEDİR ?
// Projelerimizi gerçekleştririken bir sınıfa ait değişkenlerin bir kaçını ya da tamamaını başka bir sınıf içerinde kullanmaktır.

// Kalıtım Kod Örneği

//class Program
//{
//    static void Main(string[] args)
//    {
//        papagan p   = new papagan();
//        p.tur = "Papağan";
//        p.hız = 50;
//        p.isim = "sultan";
//        p.ses = "cik";
//        p.renk = "sarı - kırmızı";
//        p.kg = 1.650;

//        Console.WriteLine("Tür : " + p.tur);
//        Console.WriteLine("İsim : " + p.isim);
//        Console.WriteLine("Hız : " + p.hız);
//        Console.WriteLine("KG : " + p.kg);
//        Console.WriteLine("Ses : " + p.ses);

//    }
//}


// Çok Biçimlilik Nedir?
/* Miras alma işleminden sonra herhangi bir alanda bulunan değerleri miras alınan sınıftaki haliyle değil de bizim istediğimiz formatta kullanım sağlamasıdır.
   * Virtual: Kalıtım alınan sınıflarda içeriğin değiştirilebilmesi için kullanılan komutlardır.
   *Override: Geçersiz kılma anlamına gelen bu komut, değiştirilecek metot yazılmadan önce metotun başına eklenir.
*/

// Çok Biçimlilik Kod Uygulaması


class Program
{
    static void Main(string[] args)
    {
        papagan p = new papagan();
        p.tur = "Papağan";
        p.hız = 50;
        p.isim = "sultan";      
        p.renk = "sarı - kırmızı";
        p.kg = 1.650;
        p.sescikar();

        Console.WriteLine("Tür : " + p.tur);
        Console.WriteLine("İsim : " + p.isim);
        Console.WriteLine("Hız : " + p.hız);
        Console.WriteLine("KG : " + p.kg);
        Console.WriteLine("Ses : " + p.sescikar());

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("********************");
        Console.WriteLine();
        karga k = new karga();
        k.kg = 1.2 ;
        k.hız = 80;
        k.isim = "karga";
        k.renk = "siyah";
        k.sescikar();

        Console.WriteLine("KG : " + k.kg + " " + "Hız : "+ k.hız + " " + "İsim : "+ k.isim + " "+ "Renk : "+ k.renk+" " +"Ses : "+ k.sescikar());
    }
}