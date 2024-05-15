
//        // Hata Yönetimi 

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int s1, s2, crs;
//            Console.WriteLine("Sayı : ");
//            s1 = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("Sayı : ");
//            s2 = Convert.ToInt16(Console.ReadLine());
//            crs = s1 + s2;
//            Console.WriteLine("Sonuc  :" + crs);

//        }
//        catch
//        {
//            Console.WriteLine("Hata var formatınızı düzeltin ");
//        }

//    }
//}


// Exception Kullanımı

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int s1, s2, crs;
//            Console.WriteLine("Sayı : ");
//            s1 = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("Sayı : ");
//            s2 = Convert.ToInt16(Console.ReadLine());
//            crs = s1 + s2;
//            Console.WriteLine("Sonuc  :" + crs);

//        }
//        catch (Exception ex)  // hatayı soyler
//        {
//            Console.WriteLine("Hata var formatınızı düzeltin ");
//            Console.WriteLine(ex);
//        }

//    }
//}


// Özel Durum Formatları
/*
 * Invalid Cast Exception: Tür dönüştürme işlemlerinde tanımlanan değişkenlere göre farklı bir türde dönüşüm yapılması durumunda karşımıza çıkan hata mesajıdır.
 * Index Out Of Range Exception: Dizide bulunmayan değerler ile karşılaşınca oluşan hata mesajıdır.
 * Divided By Zero: Sıfıra bölme yapılmak istenildiği zaman oluşan hata mesajıdır.
 * Format Exception: Sayısal bir alana sayısal olmayan bir değer girilmesi durumunda oluşan hata mesajıdır.
 * Overflow Exception: Bir değişkenin aralıklarının dışına çıkılması durumunda karşılaşılan hata mesajıdır.
 * Argument Null Exception: Aritmetik bir alanın boş bırakılması durumunda karşıma çıkan hata mesajıdır.
 * Arithmetic Exception: Matematiksel hatalarda oluşan hata mesajıdır.1
 */

//Format Exception

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int s1, s2, crs;
//            Console.WriteLine("Sayı : ");
//            s1 = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("Sayı : ");
//            s2 = Convert.ToInt16(Console.ReadLine());
//            crs = s1 + s2;
//            Console.WriteLine("Sonuc  :" + crs);

//        }
//        catch (FormatException) 
//        {
//            Console.WriteLine(" Lütfen sadece sayısal değerler giriniz! ");
//        }

//    }
//}

// Over Flow Exception

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int s1, s2, crs;
//            Console.WriteLine("Sayı : ");
//            s1 = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("Sayı : ");
//            s2 = Convert.ToInt16(Console.ReadLine());
//            crs = s1 + s2;
//            Console.WriteLine("Sonuc  :" + crs);

//        }
//        catch (FormatException)
//        {
//            Console.WriteLine(" Lütfen sadece sayısal değerler giriniz! ");
//        }
//        catch (OverflowException)
//        {
//            Console.WriteLine("Lütfen aralığı dışında değer girmeyin !");
//        }


//    }
//}

// Finally

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int s1, s2, crs;
//            Console.WriteLine("Sayı : ");
//            s1 = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("Sayı : ");
//            s2 = Convert.ToInt16(Console.ReadLine());
//            crs = s1 + s2;
//            Console.WriteLine("Sonuc  :" + crs);
//        }
//        catch (Exception)
//        {
//            Console.WriteLine("HATA");
//        }
//        finally 
//        {
//            Console.WriteLine("Burası Çalıştı.");
//        }
//    }
//}