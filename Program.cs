

// KARAR YAPILARI:

// Temelde iki komutu vardır if - else

/*syntax yapısı: 
    if (şart) {
     işlem 1
    }else
     işlem 2
    }
*/
// OPERATÖRLER
/*
 * =  : atama 
 * == : eşit mi ?
 * >  : büyük mü ?
 * <  : küçük mü ?
 * != : eşit değilse
 * &  : ve
 * |  : veya
 * %  : mood (tek mi - çift mi )
 */

// IF - ELSE KULLANIMI 
/*
string sehir;
Console.WriteLine("Şehir adı: ");
sehir = Console.ReadLine();
if (sehir == "adana") // klavyedne de anı fontla girilmeli yoksa hata verir
{
    Console.WriteLine("doğru şehir");
}
else
{
    Console.WriteLine("yanlış şehir");
}
*/

//Öğrenci Sınav-Not Uygulaması
/*
int sayi;
Console.WriteLine("Syı giriniz: ");
sayi = Convert.ToInt16(Console.ReadLine());

if (sayi == 23)
{
    Console.WriteLine("SAYI DOĞRU");
}
else
{
    Console.WriteLine(" sayı yanlış");
}


int s1, s2, s3, ort;
Console.WriteLine(" 1. sınav notunuzu giriniz");
s1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" 2. sınav notunuzu giriniz");
s2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" 3.  sınav notunuzu giriniz");
s3 = Convert.ToInt32(Console.ReadLine());

ort = (s1 + s2 + s3) / 3;
Console.WriteLine( "Ortalamanız: "+ort);

if (ort >= 50)
{
    Console.WriteLine("DERSİ GEÇTİNİZ!");
}
else {
    Console.WriteLine("DERSİ GEÇEMEDİNİZ");
}

*/

// Karar Yapıları ile Ve-Veya Operatörlerinin Kullanımı
/*
string kullanıcı, sifre;
Console.WriteLine("kullanıcı adınız: ");
kullanıcı = Console.ReadLine();
Console.WriteLine(" şifreniz: ");
sifre = Console.ReadLine();

if (kullanıcı == "Freya" & sifre == "12456")
{
    Console.WriteLine(" WELCOME ");
}
else
{
    Console.WriteLine("HATA");
}
*/

// Birden Fazla if Bloğu Kullanımı

/*
int s1, s2, s3, ort;
Console.WriteLine(" Sınav 1: ");
s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Sınav 2: ");
s2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sınav 3:");
s3 = Convert.ToInt32(Console.ReadLine());
ort = (s1 + s2 + s3) / 3;
Console.WriteLine("Ortalamanız :" +ort);
Console.WriteLine("");

if (ort <= 0)
{

    Console.WriteLine(" HATA : Ortalamanız 0 dan küçük olamaz ");
    
}
if (ort>= 0 & ort < 50)
{
    Console.WriteLine(" Başarısız ");
}
if (ort >= 50 & ort < 65)
{
    Console.WriteLine(" Geçer");

}
if (ort > 65 & ort <= 70)
{
    Console.WriteLine(" Orta ");
}
if (ort > 70 &  ort < 85)
{
    Console.WriteLine(" iyi ");

}
if (ort >= 85 & ort <= 100)
{
    Console.WriteLine(" Başarılı ");
}
if(ort > 100)
{
    Console.WriteLine(" HATA : Ortalamanız 100 den büyük olamaz");
}

*/

// "Eşit Değilse" Operatörü ile Karar Yapıları

/*
char karakter;
Console.WriteLine("Karakteri giriniz : ");
karakter = Convert.ToChar(Console.ReadLine());
Console.WriteLine();
if (karakter != '*')
{
    Console.WriteLine("Hatalı giriş yaptınız !");
}
else
{
    Console.WriteLine(" HOŞ GELDİNİZ ! ");
}
    */

// Bilgi Yarışması Projesi - 1
/* KURALLAR :
 *  TOPLAM SORU SAYISI : 3
 *  HER SORU 4 ŞIK
 *  DİĞER SORUYA GEÇE BİLMEK İÇİN DOĞRU CEVAP VERMEK GEREKLİ 
 *  YANLIŞ CEVAPTA YARIŞMA SONA ERER
 *  3 SORUNUN TAMAMI DOĞRU İSE YARIŞMA BİTER.
 */
/*
Console.WriteLine("Bilgi Yarışması");
Console.WriteLine();
Console.WriteLine();
int soru = 1;
string cevap;
if (soru == 1)
{
    Console.WriteLine("Mustafa Kemal Atatürk kaç yılında doğmuştur ?");
    Console.WriteLine();
    Console.WriteLine(" A) 1998");
    Console.WriteLine(" B) 1881");
    Console.WriteLine(" C) 1919");
    Console.WriteLine(" D) 1923 ");
    Console.WriteLine();
    Console.Write(" Cevap :");
    cevap = Console.ReadLine();
    Console.WriteLine(); 

    if (cevap == "b" | cevap == "B")
    {
     // Console.WriteLine(" DOĞRU Cevap");
     soru = soru + 1;

    }
    else
    {
        Console.WriteLine(" Yanlış Cevap OYUN BİTTİ puan: 0");
    }
}
if (soru == 2)
{
    Console.WriteLine("Mustafa Kemal Atatürk milli mücadele için Samsun'a kaç yılında çıkmıştır?");
    Console.WriteLine();
    Console.WriteLine(" A) 1998");
    Console.WriteLine(" B) 1881");
    Console.WriteLine(" C) 1919");
    Console.WriteLine(" D) 1923 ");
    Console.WriteLine();
    Console.Write(" Cevap :");
    cevap = Console.ReadLine();
    Console.WriteLine(); 

    if (cevap == "c" | cevap == "C")
    {
        // Console.WriteLine(" DOĞRU Cevap");
        soru = soru + 1;

    }
    else
    {
        Console.WriteLine(" Yanlış Cevap OYUN BİTTİ puan :10 ");
    }
}
if (soru == 3)
{
    Console.WriteLine("Türkiye Cumhuriyeti kaç yılında kurulmuştur?");
    Console.WriteLine();
    Console.WriteLine(" A) 1998");
    Console.WriteLine(" B) 1881");
    Console.WriteLine(" C) 1919");
    Console.WriteLine(" D) 1923 ");
    Console.WriteLine();
    Console.Write(" Cevap :");
    cevap = Console.ReadLine();
    Console.WriteLine(); 

    if (cevap == "d" | cevap == "D")
    {
        Console.WriteLine(" Tebrikler Tüm Cevaplar DOĞRU ");

    }
    else
    {
        Console.WriteLine(" Yanlış Cevap OYUN BİTTİ ");
    }
}
*/

// Switch Case Kullanımı

// Dallanmanın fazla olduğu durumlarda kullanılan karar yapısı alt başlığıdır.

/* switch (Deger)
            {
         Case1: işlemler
            Break;
             ...
        Default : işlemler
            Break;
              }
*/


//  Switch Case ile Plaka-Şehir Uygulaması
/*
byte plaka;
Console.WriteLine(" Lütfen plaka giriniz: ");
plaka = byte.Parse(Console.ReadLine());
switch (plaka)
{
    case 1:Console.WriteLine("Merhaba ADANA "); break;
    case 2: Console.WriteLine("Merhaba ADIYAMAN"); break ;
    case 3: Console.WriteLine("Merhaba AFYON"); break;
    default: Console.WriteLine(" Henüz Bu Şehir Bilgisi Girilmedi "); break;
}
*/

// Switch Case ile String Değişkenlerin Kullanımı
/*
Console.WriteLine(" String Değişkenler ile Switch Case Kullanımı");
Console.WriteLine();
string mevsim;
Console.WriteLine("Lütfen mevsim giriniz : ");
mevsim = Console.ReadLine();
switch (mevsim)
{
    case "kis": Console.WriteLine("Aralık - Ocak - Şubat"); break;
    case "ilkbahar": Console.WriteLine("Mart - Nisan - Mayıs");break;
    case "yaz": Console.WriteLine("Haziran - Temmuz - Ağustos"); break;
    case "sonbahar":Console.WriteLine(" Eylül - Ekim - Kasım "); break;
   

    default:Console.WriteLine("hatalı mevsim girişi");break; 
}
*/