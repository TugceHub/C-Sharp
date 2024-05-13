// METOD NEDİR?
/* Belli bir işlemi gerçekleştiren ve geliştirciyi kod tekrarından kurtaran yapılardır.
 * Metodlar temelde 2'ye ayrılır.
 *  1 : Geriye değer döndüren metodlar 
 *  2 : Geriye değer döndürmeyen metodlar.
 */

// ERİŞİM BELİRLEYİCİLER 
/* Metodlarımıza kimlerin erişim sağlayabileceğinin kontrolünün yapıldığı program komutlarıdır.
 * 
 * Public :  Herkese açık
 * Private : Gizli
 * Protected : Tanımlandığı sınıf ve o sınıfı miras alan sınıflardan erişim sağlanır.
 */
// Metodlar ve sınıflar bir zinzirin iki halakası gibidir ikisnide birlikte ihtiyac vardır.
// Birbirinden ayrılmaz iki bütündür.

// Static Kavramı
/* içinde bukunduğu sınıfan nesne oluşturulmadan kullanılan yapılardır.
 */

// Metodların Tanımlanması

/* rişim_belirleyici_türü static metot_türü metod_adı()
                        {
                     işlemler
                        }
*/


// Geriye Değer Döndürmeyen Metot Örnekleri - 1

//class Program
//{
//    // Artık Tanımlamaları Bu Kısıma yapıyoruz. ***
//    // erişim türünü belilemezsek var sayılan private olarak geliyor.

//    public static void yazdir ()
//    {
//        Console.Write("bu bir metottur.");
//        Console.WriteLine();
//        Console.Write("burası metodun başka bir satırıdır.");
//        Console.WriteLine();

//    }
//    // geriye değer döndürmeyecek bu yüzden : void
//    static void Main(string[] args)
//    {
//        yazdir();
//        Console.WriteLine("**********************");
//        Console.WriteLine();
//        yazdir();
//        Console.Read();
//    }

//}

// Geriye Değer Döndürmeyen Metot Örnekleri - 2

//class Program
//{

//    public static void yazdir()
//    {
//        Console.Write("bu bir metottur.");
//        Console.WriteLine();
//        Console.Write("burası metodun başka bir satırıdır.");
//        Console.WriteLine();

//    }

//    //public static void toplam()
//    //{
//    //    int s1 = 24, s2 = 30;
//    //    int toplam = s1 + s2;
//    //    Console.WriteLine(toplam);
//    //}
//    //// metod isimi ile değişken isimi aynı olmamalı

//    public static void toplamaMetodu()
//    {
//        int s1 = 24, s2 = 30;
//        int toplam = s1 + s2;
//        Console.WriteLine(toplam);
//    }

//    public static void yazıBosluk()
//    {
//        Console.WriteLine();
//        Console.WriteLine("**********************");
//        Console.WriteLine();
//    }

//    public static void ardisikSayilar()
//    {
//        for (int i = 1; i <= 10; i++) {
//            Console.Write(i + " ");
//        }
//    }

//    static void Main(string[] args)
//    {
//        yazdir();
//        //Console.WriteLine("**********************");
//        //Console.WriteLine();
//        yazıBosluk();
//        yazdir();
//        yazıBosluk();
//        toplamaMetodu();
//        yazıBosluk();
//        ardisikSayilar();       
//    }
// }

//Geriye Değer Döndürmeyen Metotlarda Parametre Kullanımı
//class Program
//{
//    public static void MetinYaz(string p)
//    {
//        Console.WriteLine("**************");
//        Console.WriteLine();
//        Console.WriteLine(p);
//        Console.WriteLine();
//        Console.WriteLine("**************");
//    }
//    static void Main(string[] args)
//    {
//        MetinYaz("Merhaba Dünya"); // içerisine p ye atama yaptık.//        
//    }
//}


// Geriye Değer Döndürmeyen Metotlarda Parametrenin Klavyeden Alınması
//class Program
//{
//    public static void parametreAL(string parametre)
//    {
//        Console.WriteLine("**************");
//        Console.WriteLine();
//        Console.WriteLine(parametre);
//        Console.WriteLine();
//        Console.WriteLine("**************");
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("kelimeyi giriniz : " );
//        string girdi = Console.ReadLine();
//        Console.WriteLine();
//        parametreAL(girdi);
//        Console.Read();
//    }
//}

// Geriye Değer Döndüren Metotlar
/*
 * Geriye bir dönüş tipi alarak oluşturulan metodlardır.
 * Geriye değer döndüren metodlarda ise int, string veya sınıfa ait değer türü yazılır.
 * Geriye dönecek değer return ifadesi ile belirlenir.
 */

//     public int max ( int x, int y )  
//     public : erişim belirleyici/int : geridönüş türü / max : metodun adı / ( int x, int y ) : parametre değerleri
//     {
//         if( x>y )
//            return x;
//         else
//            return y;
//     }
//{} : body of metod


// Geriye Değer Döndüren Metot Örneği

//class Program
//{
//    public static int toplama() {
//        int s1, s2, sum;
//        s1 =25;
//        s2 =35;
//        sum = s1 + s2;  
//        return sum;
//    }  
//    static void Main(string[] args)
//    {
//        Console.WriteLine(toplama());
//    }
//}


//  Geriye Değer Döndüren Parametreli Metot

//class Program
//{
//    public static int toplam(int s1, int s2)
//    {
//        int sonuc;
//        sonuc = s1 + s2;
//        return sonuc;
//    }

//    static void Main(string[] args)
//    {
//        // Parametreli geriye değer dündğren metot
//        //Console.WriteLine(toplam(10, 15));

//        // klavyeden değer alma
//        int sayi1, sayi2, toplama;
//        Console.WriteLine("1.sayıyı giriniz:");
//        sayi1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("2.sayıyı giriniz:");
//        sayi2 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Sonuc: " + toplam(sayi1, sayi2));
//        Console.WriteLine(toplam(7, 8));  // koddan gelen değer

//        Console.Read();
//    }
//}


//  Metotları Aşırı Yükleme ( OVER LOAD )
/*
 * Görevleri farklı olmak şartıyla aynı isimde birden fazla metod bulunmasıdır.
 */

//class Program
//{
//    public static int ortalama (int s1, int s2)
//    {
//        int sonuc = (s1 + s2) / 2;
//        return sonuc;
//    }

//    public static int ortalama(int s1, int s2, int s3)
//    {
//        int sonuc = (s1 + s2 + s3) / 3;
//        return sonuc;
//    }


//    static void Main(string[] args)
//    {
//        // Console.WriteLine("Ortalma : " + ortalama(50, 80));
//        Console.WriteLine(ortalama());
//        Console.Read();
//    }
//}

