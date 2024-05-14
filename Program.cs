// Matematiksel Fonksiyonlar
/*
 * Abs : Mutlak
 * Ceiling : Üst tabana yuvarla
 * Floor   : Alt tabana yuvarla 
 * Sqrt    : Karekök
 * Pow     : Üs alma 
 * Pi      : Pi sayısı
 * */

// Math :
//double sayi;
//Console.WriteLine("Sayıyı giriniz :");
//sayi = Convert.ToDouble(Console.ReadLine());

//// Mutlak Değer:
//Console.WriteLine("Mutlak Değer :" +Math.Abs(sayi));
//// Üst taban :
//Console.WriteLine("Üst Taban : " + Math.Ceiling(sayi));
//// Alt Taban :
//Console.WriteLine("Alt Taban : " + Math.Floor(sayi));
//// Kare Kök :
//Console.WriteLine("Karekök : " + Math.Sqrt(sayi));

//String Fonksiyonlar
/*
 * Metinsel ifadeler ile işlemler yapabilmek için kullanlır
 * Conctac    : birleştime
 * Length     : uzunluk
 * İndex of   : Metin arama
 * Starswith   : İlgili parametere ile mi başlar.
 * Toupper    : büyük harf
 * Tolower    : küçük harf
 * Remove     : İstanilen karekterden itibaren siler
 * Replace    : Değiştirme
 * Substring  : İstaneilen karakterden itibaren işlem yapar 
 * Trim       : Sağ - sol boşlukları kaldır.
 */

// String Fonksiyon Kullanımları 1

//string metin, metin2;
//Console.WriteLine("Metini giriniz : ");
//metin = Console.ReadLine();
//Console.WriteLine("Metini giriniz : ");
//metin2 = Console.ReadLine();

//Console.WriteLine("Concat ile birleştirme : " + string.Concat(metin, metin2));
//Console.WriteLine("Metin 1 için karakter sayısı : " + metin.Length);
//Console.WriteLine("İndex of Örneği : " + metin.IndexOf("aydın")); // index 0 ise mevcut || - değer döndürür.
//Console.WriteLine("Startswith Örneği : " + metin.StartsWith("o"));
//Console.WriteLine("Merhaba Dünya" + metin.Trim());
//Console.WriteLine("Büyük harf : " + metin.ToUpper());
//Console.WriteLine("Küçük harf : " + metin.ToLower());
//Console.WriteLine("Remove Metodu  : " + metin.Remove(5)); // index numasından sonrasını siler.
//Console.WriteLine("Replace Fonksiyonu  : " + metin.Replace("a", "A")); // eski karakter, yeni karakter
//Console.WriteLine("Substring Fonksiyonu : " + metin.Substring(4)); // indeks numarasından sonrasın yazar  indeks 

// Tarih Zaman Fonksiyonlar
/*
 * Anahtar kelime : Datetime
 * Kullanım Şekli : DateTime.Now
 * Day, mounth, year, hour, second, ...vb.
 * Timespan : 2 tarih arasındaki farkı hesaplar.
 */


//Console.WriteLine("Bugünün gün bilgisi : " + DateTime.Now.Day);
//Console.WriteLine("Bugünün ay bilgisi : " + DateTime.Now.Month);
//Console.WriteLine("Bugünün yıl bilgisi : " + DateTime.Now.Year);
//Console.WriteLine("Bugünün saat bilgisi : " + DateTime.Now.Hour);
//Console.WriteLine("Bugünün dk bilgisi : " + DateTime.Now.Minute);
//Console.WriteLine("Bugünün sn bilgisi : " + DateTime.Now.Second);
//Console.WriteLine("Bugünün kısa  bilgisi : " + DateTime.Now.ToShortDateString());
//Console.WriteLine("Bugünün uzun  bilgisi : " + DateTime.Now.ToLongDateString());

// Time Span Kullanımı

//TimeSpan zaman;
//int gunfarki;
//DateTime tarih1, tarih2;
//tarih1 = Convert.ToDateTime("20.08.1997");
//tarih2 = DateTime.Now.Date;
//zaman = tarih2 - tarih1;
//gunfarki = zaman.Days;
//Console.WriteLine(" Fark :" + gunfarki);



