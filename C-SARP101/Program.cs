// See https://aka.ms/new-console-template for more information

// C# ile Algoritma ve Programlama 101

// DEĞİSKENLER

//STRİNG DEĞİŞKENLER

// Metinsel ifadelerde yapılır 

//string sehir;
//kod blogunun altı yeşil ise hata değil kırmızı ise hatadır. 
/*sehir = "Ankara";
Console.WriteLine(sehir);
Console.Read(); // ektan kapanmasın diye */

// İNT DEĞİŞKENLER

// A ritmetik tam sayılar üzerinde yapılan işlemler
/*
int sayi, sayi2, toplam;
sayi = 24;
sayi2 = 13;
toplam = sayi + sayi2;
Console.WriteLine(toplam);
Console.Read(); */

// dikdirtgen alan ve cevresi 

/* //EGZERSİZ 
int kisa, uzun, cevre, alan;
kisa = 12;
uzun = 10;
cevre =  (kisa + uzun) * 2 ;
alan = (kisa * uzun) ;
Console.WriteLine("Çevresi :" + "" + cevre);
Console.WriteLine("Alanı :"+" "+alan);
Console.Read(); */

// ARİTMETİK 4 İSLEM
/*
int s1, s2, toplam, carpim, bolum, fark;
Console.WriteLine("******* Aritmetik islemler******");
Console.WriteLine();
s1 = 20;
s2 = 5;
toplam = 20 + 5;
carpim = 20 * 5;
bolum = 20 /5;
fark = 20 -5;
Console.WriteLine("TOPLAM:"+" "+toplam);
Console.WriteLine("ÇARPIM:"+" "+carpim);
Console.WriteLine("BÖLÜM:"+" "+bolum);
Console.WriteLine("FARK:"+" "+fark);
Console.Read();
*/

//DOUBLE DEĞİŞKENLER
// Yalnıza tam sayılar değil, ondalık sayılar üzerinde de işlemler yapan değişken türüdürç
/*
double sayi;
sayi = 25.9;
Console.WriteLine(sayi);

Console.Read();

double s1, s2, ort;
s1 = 78;
s2 = 85;
ort =(s1 + s2)/2;
Console.WriteLine(ort);

Console.Read(); */

// KLAVYEDEN VERİ GİRİŞLERİ
/*
Console.ReadLine(); -> Kullanıcıdan alınan metinsel ifadeyi hafızada tutar.
Eğer aritmetik bir ifade gireceksem dönüştürmen gerekir.*//*

Console.ReadKey(); -> Klavyeden basılan tuşun bilgisini verir.
Console.Read(); -> Girilen parametrenin sadece ilk karakterinin ascii kod karşılığını verir.
*/
// ReadLine();  UYGULAMASI
/*
string ad, soyad;
Console.WriteLine("Adınız:");
ad = Console.ReadLine();
Console.WriteLine("Soyadınız:");
soyad = Console.ReadLine();

Console.WriteLine(ad + " " + soyad + " "+ "HOŞ GELDİNİZ !" );
*/

// İNT DÖNÜŞÜMLER

// Dönüşümler için anahtar kelime : Convert
/*
int sayi;
Console.WriteLine("sayıyı giriniz");
sayi = Convert.ToInt16(Console.ReadLine()); 
Console.Write(sayi);

Console.Read(); */
/*
int s1, s2, toplam;
Console.Write("SAYI GİRİNİZ:");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("SAYI GİRİNİZ:");
s2 = Convert.ToInt32(Console.ReadLine());
toplam = s1 + s2;
Console.Write("TOPLAM:");
Console.WriteLine(toplam);
*/

// Klavyeden kısa ve uzun kenarı girilen dikdörtgenin ala ve çevresini hesaplayan kodu yazınız.
/*
int uk, kk, alan, cevre;
Console.WriteLine("Kısa kenar uzunluğunu giriniz:");
uk=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Uzun kenar uzunluğunu giriniz:");
kk=Convert.ToInt16(Console.ReadLine());
alan = uk*kk;
cevre = uk * 2 + kk * 2;
Console.Write("Alan:");
Console.WriteLine(alan);
Console.Write("Çevre:");
Console.WriteLine(cevre);
Console.Read(); */

// Klavyeden girilen 2 sayıya aritmetik 4 işlem uygulayan kodu yazın.
/*

int s1, s2, top, bol, carp, fark;
Console.WriteLine("Sayı1:");
s1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayı2:");
s2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Toplam:");
top= s1 + s2;
Console.WriteLine(top);
Console.WriteLine("Bölüm:");
bol = s1 / s2;
Console.WriteLine(bol);
Console.WriteLine("Çarpım:");
carp = s2* s1;
Console.WriteLine(carp);
Console.WriteLine("Fark:");
fark = s1- s2;
Console.WriteLine(fark);
Console.Read(); */

// Double Dönüşümler








