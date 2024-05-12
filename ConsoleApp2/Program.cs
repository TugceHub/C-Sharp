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

// Klavyeden ondalıklı sayı girişinde kullanılır 
//Convert.ToDouble();

//NOT: klavyeden giriyorsak ondalıklı syaıyı , şle ayırmalıyız. Kod ile giriyorsak . ile ayırılmalıç
/*
double sayi1, sayi2, sum;
Console.WriteLine("sayı giriniz:");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("sayı giriniz:");
sayi2 = Convert.ToDouble(Console.ReadLine());
sum= sayi1 + sayi2;
Console.WriteLine("sonuç:" +  sum);

Console.Read(); */

// Char Değişkenler
// tek karakterler uzerinde işlmler gerçekleştiren değişken türüdür.
// karakterler '' içine yazılır.

/*
char deger;
deger = '3';
Console.WriteLine(deger);
*//*

char secim;
Console.WriteLine("Lütfen seçimiinizi yapınız: ");
secim = Convert.ToChar(Console.ReadLine());
Console.Write("seçiminiz:"+secim);
Console.Read();*/

// BYTE Değişkenler
// 0-255 arası tam sayılar üzerinde işlem yapan değişken türümüzdür.

/*
byte s1, s2, toplam;
s1 = 24;
s2 = 36;
toplam = Convert.ToByte(s1+s2); // toplama işleminde donusum ister
Console.WriteLine(toplam); 

byte s1, s2, car;
Console.Write("1. sayi: ");
s1 = Convert.ToByte(Console.ReadLine());
Console.Write("2.sayi: ");
s2 = Convert.ToByte(Console.ReadLine());
car = Convert.ToByte(s1*s2);
Console.WriteLine("Carpim: "+car);

Console.Read(); */

// Sbyte Değişkeler
//-128 - +127 arası tam sayıılarda üzerinde işlem yapar
// S: signed
/*
sbyte sayi, sayi2, sum;
Console.Write("sayı giriniz: ");
sayi = Convert.ToSByte(Console.ReadLine());
Console.Write("sayı giriniz: ");
sayi2 = Convert.ToSByte(Console.ReadLine());
sum =Convert.ToSByte( sayi + sayi2);
Console.WriteLine(sum);
Console.Read();*/

// Float Değişkenler
// Ondalık sayılar üzernde işlem yapmak iöin bullanılr ancak double değişkeninden küçüktür.
// tanımladığın deger sonuna f koyman gerekir.
/*
float sayi;
sayi = 345.7890f;
Console.WriteLine(sayi);


float s1, s2, sum;
Console.WriteLine("SAYI 1:");
s1 = float.Parse(Console.ReadLine());
Console.WriteLine("sayı 2:");
s2 = float.Parse(Console.ReadLine());
sum = s1 + s2;          // byte ve sbytedaki hatayı vermedi
Console.WriteLine(sum);

Console.Read(); */

// DEĞİŞKENLERDE Min - Max VALUE
// BİR DEĞİŞKENİN MİN VEYA MAX DEĞERİNE NASL ULAŞIRIM ?,
/*
Console.WriteLine("Byte max  -  min : ");
Console.Write(byte.MaxValue);
Console.Write("  ");
Console.WriteLine(byte.MinValue);

Console.WriteLine("integer max  -  min : ");
Console.Write(int.MaxValue);
Console.Write("  ");
Console.WriteLine(int.MinValue);

Console.WriteLine("float max  -  min : ");
Console.Write(float.MaxValue);
Console.Write("  ");
Console.WriteLine(float.MinValue);
Console.Read();
*/

//sHORT dEĞİŞKENLER
//+32768 İLE + 32767 arası tam sayılar uzerinde işlem yapar
//ToInt16 karşılığıdır.
/*
short s1, s2, sum;
s1 = 650;
s2 = 3654;
sum = (short)(s1 + s2); 
Console.WriteLine(sum); 
*/
/*
short a, b, c;
Console.WriteLine("a:");
a = short.Parse(Console.ReadLine());
Console.WriteLine("b:");
b = short.Parse(Console.ReadLine());
 // c = (short)(a + b);
c = Convert.ToInt16(a+b);
Console.WriteLine(c);
*/

// Ushort Değişkenler
// 0 - 65535 arasındaki tam sayılar üzerinde işlem yapan değer türüdür.
/*
ushort s1, s2, sum;
s1 = 34;
s2 = 56;
sum = (ushort)(s1+s2);
Console.WriteLine(sum);
*/
/*
ushort k1, k2, alan, cevre;
Console.WriteLine("kısa kenar uzunluğunu giriniz:");
k1 = ushort.Parse(Console.ReadLine());
Console.WriteLine("uzun kenar uzunluğunu giriniz");
k2 = ushort.Parse(Console.ReadLine());

alan = (ushort)( k1 * k2);
cevre = (ushort)((k1 + k2) * 2);
Console.WriteLine("Alan:" +  " " + alan + "  " + "Çevre:" + " " + cevre);
*/

// Decimal Değişkenler
// doubledan daha geniş sayı aralığında bulunan ondalıklı sayılar üzerinde işlem yapan değişkenlerdlr

/*decimal kenar, alan, cevre;
Console.Write("Kenarı giriniz: ");
kenar = Convert.ToDecimal(Console.ReadLine());
alan = kenar * kenar;
cevre = kenar * 4;
Console.WriteLine();
Console.WriteLine("Alan: " + alan + "  " +"Çevre: "+cevre );

decimal sayi;
sayi = 4.679m;
Console.WriteLine(sayi);*/

// Bool değişkenler
// true - false şeklinde değer alan değişken türüdür.
// bool ifadesi boolean ifadesinin takma isimidir.
/*
bool durum;
durum = false;
Console.WriteLine("Öğrenci sınavı geçti mi ?" + "" +durum);

bool uyemi;
Console.WriteLine("Kullanıcı sisteme üye mi?");
uyemi = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Kullanıcının Üyelik Durumu : " + uyemi);
*/

Console.Read();













