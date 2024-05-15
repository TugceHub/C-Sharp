// Metin Belgesi İşlemleri
/*
 * Çeşitli belge türlerinin ( metin belgesi, word, excel ..vb.)
 * Dosya işlemleri sayesinde kodlar üzerşnden metin belgesi oluşturabilir, yazabilr, silebilir veya değiştirebiliriz.
 * Dosya işlemleri aslında bşr veri tabanıdır.
 */

// Metin Belgesi işlemleri için kullandığımız kütüphane : System.IO


// Yeni Metin Belgesi Oluşturma
//class Program
//{
//    static void Main(String[] args)
//    {
//        StreamWriter sw = new StreamWriter("C:\\Users\\blutf\\OneDrive\\Desktop\\fatma.txt");
//    }
//}

// Yeni Metin Belgesi İçine Yazı Yazma

//class Program
//{
//    static void Main(String[] args)
//    {
//        StreamWriter sw = new StreamWriter("C:\\Users\\blutf\\OneDrive\\Desktop\\fatma.txt");
//        sw.WriteLine("lorem ipsum lorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsumlorem ipsum" );
//        sw.Close();
//    }
//}


// Metin Belgesi İçine Klavyeden Veri Girişi

//class Program
//{
//    static void Main(String[] args)
//    {
//        StreamWriter sw = new StreamWriter("C:\\Users\\blutf\\OneDrive\\Desktop\\fatmaB2.txt");
//        string metin;
//        Console.WriteLine("Metini giriniz : ");
//        metin = Console.ReadLine();
//        sw.Write(metin);
//        sw.Close();
//    }
//}

// Metin Belgesini Okuma

class program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("adres", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string metin = sr.ReadLine();
        while (metin != null)
        {
            Console.WriteLine(metin);
            metin = sr.ReadLine();

        }
        sr.Close();
        fs.Close();
    }