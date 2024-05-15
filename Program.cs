class Progran
{
    static void Main(string[] args)
    {
        int toplamFiyat = 0;
        string sec;
        // Kategoriler
        Console.WriteLine("************************************************************************************");
        Console.WriteLine();
        Console.WriteLine("***  Türkçe Kitaplar Kategorisi  ***  Yabancı Kiatplar Kategorisi  ****************");
        Console.WriteLine();
        //Kitap listesi
        Console.WriteLine("**  1 - Çalıkuşu  : Reşat Nuri           **   7 - Tuna Kılavuzu : Jul Verne          *");
        Console.WriteLine();
        Console.WriteLine("**  2 - Yaban  : Yakup kadri             **   8 - Bir kuzey Macerası  : Jack London *");
        Console.WriteLine();
        Console.WriteLine("**  3 - Sinekli Bakkal : Halide Edip     **   9 - Altıncı Koğuş : Anton Çehov       *");
        Console.WriteLine();
        Console.WriteLine("**  4 - Tehlikeli Oyunlar  : O.Atay      **   10 - Kumarbaz : Dostoyevski           *");
        Console.WriteLine();
        Console.WriteLine("**  5 - Geçtiğim Günlerden:H.Ali Yücel   **   11 - İki Şehirin Hikayesi : C.Dickens *");
        Console.WriteLine();
        Console.WriteLine("**  6 - Kuyucaklı Yusuf : S.Ali          **   12 - Vişne Bahçesi : Anton Çehov      *");
        Console.WriteLine();
        Console.WriteLine("*************************************************************************************");
        //işlemler menüsü
        Console.WriteLine("***** İŞLEMLER MENÜSÜ *****");
        Console.WriteLine();
        Console.WriteLine(" 1 - Fiyat Sorgulama ");
        Console.WriteLine(" 2 - Yeni Okur Kaydı ");
        Console.WriteLine(" 3 - Günün Kitabı ");
        Console.WriteLine(" 4 - Kitap Arşivi ");
        Console.WriteLine(" 5 - Yeni Kitap Satın Al");
        Console.WriteLine(" 6 - Oyun ");
        Console.WriteLine();
        Console.Write(" Yapmak istediğiniz işlemin numarası : ");
        // İşlem Seçimi
        char islem;
        islem = Convert.ToChar(Console.ReadLine());
        if (islem == '1')
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını girin : ");
            string no;
            no = Console.ReadLine();
            switch (no)
            {
                case "1": Console.WriteLine("Çalıkuşu : 12TL"); break;
                case "2": Console.WriteLine("Yaban : 14TL"); break;
                case "3": Console.WriteLine("Sinekli Bakkal  : 16TL"); break;
                case "4": Console.WriteLine("Tehlikeli Oyunlar : 11TL"); break;
                case "5": Console.WriteLine("Geçtiğim Günlerde : 8TL"); break;
                case "6": Console.WriteLine("Kuyucaklı Yusuf : 13TL"); break;
                case "7": Console.WriteLine("Tuna Kılavuzu : 17TL"); break;
                case "8": Console.WriteLine("Bir kuzey Macerası : 4TL"); break;
                case "9": Console.WriteLine("Altıncı Koğuş : 5TL"); break;
                case "10": Console.WriteLine("Kumarbaz : 13TL"); break;
                case "11": Console.WriteLine("İki Şehirin Hikayesi : 10TL"); break;
                case "12": Console.WriteLine("Vişne Bahçesi : 6TL"); break;
                default: Console.WriteLine("Böyle bir kitap mevcut değil."); break;

            }
        }
        if (islem == '2')
        {
            Console.WriteLine("***** Yeni Okur Kayıt *****");
            string ad, soyad, üni;
            Console.Write("Adınız : ");
            ad = Console.ReadLine();
            Console.Write("Soyadınız : ");
            soyad = Console.ReadLine();
            Console.Write("Üniversite adı: ");
            üni = Console.ReadLine();

            string dosya = "C:\\Users\\blutf\\OneDrive\\Desktop\\kullanici.txt";
            Console.WriteLine();
            Console.WriteLine("Adınız : " + ad + " " + "Soyadınız : " + soyad + " " + "Üniversite adı  :" + üni);
            Console.WriteLine();
            StreamWriter ky = new StreamWriter(dosya);
            ky.WriteLine("Adınız : " + ad + " " + "Soyadınız : " + soyad + " " + "Üniversite adı  :" + üni);
            ky.Close();
            Console.WriteLine();
            Console.WriteLine("KAYIT BAŞARILI");
        }
        if (islem == '3')
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine(" ***** Bugünün kitabı : Tehlikeli Oyunlar *****");
            Console.WriteLine();
            Console.WriteLine("***********************************************");
        }
        if (islem == '4')
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            FileStream fs = new FileStream("C:\\Users\\blutf\\OneDrive\\Desktop\\Kitaplar.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string metin = sr.ReadLine();
            while (metin != null)
            {
                Console.WriteLine(metin);
                metin = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********************************************");


        }
        if (islem == '5')
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Alacağınız Kitabın İsimi : ");
                sec = Console.ReadLine();
                if (sec == "1")
                {
                    toplamFiyat = toplamFiyat + 12;
                }
                else if (sec == "2")
                {
                    toplamFiyat = toplamFiyat + 14;
                }
                else if (sec == "3")
                {
                    toplamFiyat = toplamFiyat + 16;
                }
                else if (sec == "4")
                {
                    toplamFiyat = toplamFiyat + 11;
                }
                else if (sec == "5")
                {
                    toplamFiyat = toplamFiyat + 8;
                }
                else if (sec == "6")
                {
                    toplamFiyat = toplamFiyat + 13;
                }
                else if (sec == "7")
                {
                    toplamFiyat = toplamFiyat + 17;
                }
                else if (sec == "8")
                {
                    toplamFiyat = toplamFiyat + 5;
                }
                else if (sec == "9")
                {
                    toplamFiyat = toplamFiyat + 4;
                }
                else if (sec == "10")
                {
                    toplamFiyat = toplamFiyat + 13;
                }
                else if (sec == "11")
                {
                    toplamFiyat = toplamFiyat + 10;
                }
                else if (sec == "12")
                {
                    toplamFiyat = toplamFiyat + 6;
                }
                else
                    Console.WriteLine("Böyle bir kitap numarası yok");
                Console.WriteLine("Başaka bir kitap alamak ister misisniz ?");
                string cevp = Console.ReadLine();
                if (cevp == "h" || cevp == "H" || cevp == "hayır" || cevp == "Hayır" || cevp == "HAYIR")
                    break;
            }
            Console.WriteLine(" Toplam Tutar : " + toplamFiyat);


        }
        if (islem == '6')
        {
            Console.WriteLine();
            int tahmin = 0;
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            while (sayi != tahmin)
            {
                Console.WriteLine("Sayı giriniz;");
                tahmin = Convert.ToInt16(Console.ReadLine());
                if (tahmin > sayi){
                    Console.WriteLine("Daha Küçük");
                }
                if (tahmin < sayi)
                {
                    Console.WriteLine("Daha Büyük ");
                }
                if (tahmin == sayi) 
                {
                    Console.WriteLine("Bildiniz *****");
                    break;
                }
            }Console.Read();

        }



    }
}

