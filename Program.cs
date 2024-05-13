// DÖNGÜLER

//Belirtişen işlemlerin belli şartlar aralığında tekrar tekrar gerçekleşmesidir.
// ornegün 100 defa merhaba dünya yazdırmak gibi
// 1000 tane personel için numara atamak

/* DÖNGÜ TÜRLERİ
 *  1. FOR
 *  2. WHILE
 *  3. DO-WHILE
 *  4. FOREACH 
  */

/* For Dongüsü syntax yapısı
 *  for( başlangıç; bitiş; miktar)
 *             {
 *         işlemler
 *             }
 */

// Örnek For Döngüsü Kullanımı 1
/*
int i;
for(i=1; i<10; i++)
{
    Console.WriteLine("merhaba dünya");
} */
// BREAK POINT KULLANIMI
// break point  gri kısıma tıkadığında kırmızı nokta oluştururç
// kullanım amacı hata aldığım noktalarda programı adım adım takip etmemi sağlar.
// f5 ile çalıştır sonra f11 ile takip et

// Örnek For Döngüsü Kullanımı 2

// EKRANA 1-10 KADAR SAYI YAZDIR.

//int sayi;
//for (sayi = 1; sayi <= 10; sayi++)
//{
//    Console.WriteLine(sayi);
//}

// 0 ile 20 arası çift sayılar

//int j;
//for ( j = 0; j <=20; j+=2 )
//{
//    Console.WriteLine( j ); 
//}

//int k;
//for ( k = 1; k <= 100; k += 1)
//{
//    Console.WriteLine(k +"Merhaba İstanbul");
//}

// Döngü İçinde Karar Yapısı Kullanımı

// 0 ile 20 arası çift sayılar

//int sayi, cift;
//for (sayi = 0; sayi <= 20; sayi++) {
//    cift = sayi% 2;
//    if (cift == 0) {
//        Console.WriteLine(sayi);
//    }
//}

// Algoritmik Soru Girilen Sayının Pozitif Tam Bölenlerini Bulma

//int sayi;
//Console.WriteLine("sayıyı giriniz :");
//sayi = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine("Sayının Tam bölenleri :");
//for (int i = 1; i <=sayi; i++)
//{
//    if ( sayi % i == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

// Algoritmik Mülakat Sorusu

/* Bir bakteri türü her saatin sonunda kendini 2 ye bölerek çoğalmaktadır.
 * Yeni oluşan bakterilerde aynı şekilde çoğalmaktadır.
 * 24 saatin sonunda kaç bakteri olur?  */

//int bakteri = 1;
//for (int i = 1 ; i <= 24; i++) {
//    bakteri = bakteri * 2;
//    Console.Write("SAAT :" + " " + i);
//    Console.WriteLine(bakteri);

//}
//Console.Write("24 SAATİN SONUNDA OLUŞAN BAKTERİ SAYISI : ");
//Console.WriteLine(bakteri);

// Ardışık Sayılarla İşlemler

// 5 Faktöriyel 
//int faktoriyel = 1;
//for (int i = 5; i >= 0; i--)
//{
//    faktoriyel = faktoriyel * i;
//    //Console.WriteLine(faktoriyel); -> aşamaları gosterir
//}
//Console.WriteLine(faktoriyel);  // sonucu gosterir.

/* odev
 * klavyeden girilen sayının faktoriyelini hesaplayan uygulama
 * dongunun başlangıc değerleri buyukten kucuge değl de kucukten buyuğe olmalı.
 */

// While Döngüsü

// syntax yapısı:
/*      While(şart)
 *          {
 *       işlemler
 *          }
 */
// Özellikle veri tabanından veri çekmede çokca kullanılan bir özelliktir.

//int sayac = 1;
//while (sayac <= 10)
//{
//    Console.WriteLine("Fatma Tugce BULUT");
//    sayac++;
//}

// Do While Döngüsü
// While döngüsünde şart gerçekleşmezse çıktı alınmaz ancak dı whşle da 1 kere de olsa şart gerçekleşir.

// Do - While döngüsü syntax yapısı:
/*      Do
 *      {
 *      işlemler
 *      }
 *      While( Şart ); // şart sağlanamzsa işlemden çıkıcak bu yüzden ";" önemli.
 */

//int sayi;
//sayi = 1;
//while (sayi <= 10)
//{
//    Console.WriteLine(sayi);
//    sayi++;
//}

//int sayi = 12;
//do
//{
//    Console.WriteLine(sayi);
//    sayi++;    

//} while ( sayi <= 10);
