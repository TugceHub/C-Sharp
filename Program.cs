// DİZİLER
/*
 * Dizilerde her eleman data, her elemanın konumu ise index olarak adlandırılır.
 * Dizilerde sayma işlemi 0'dan başlar.
 * Diziler ram bellekte tutulurlar.
 * Dizi tanımlama işlemleri [] sembolü ile yapılır.
 * Dizi tanımlamalarında elemanler {} sembolü içerisine yazılır.
 * Dizi tanımlamalrında ilgili dizinin mutlaka bir değişen türü bulunur.
 */

// mutlaka bir değişken türü almak zorunda 
// hemen sonra köşeli parantez alırlar
//  string[] sehirler = { "adana", "mersin", "giresun", "ankara" };
// 4 elemanlı bir dizi oluşturduk ancak index 0 dan başlar bu yüzden 
/*  index değ
 * 0 = adana        1.eleman
 * 1 = mersin       2.eleman
 * 2 = giresun      3.eleman
 * 3 = ankara       4.eleman
 */

//   Console.Write("Dizimizin 2.Index Değeri : " + sehirler[2]);
// [] -> içerisindeki değer o sıradaki Index değerini verir.
// [2] -> index 2 yani 3. eleman bu da bizim dizimzde giresun çıktısı verir.

//   Console.WriteLine("Dizimzin 0.Indax Değeri : " +  sehirler[0]);
// Çıktımız adana

// index değerlerinin dışına çıkarsam Hata verir. Ör:
//   Console.Write(sehirler[5]);


// Int Türünde Dizi Örnekleri

//int[] sayilar = { 10, 20, 30, 40, 50, 60, 70 };
//Console.WriteLine(sayilar[4]);
// output : 50

// Dizinin tüm elemanlarını yazdırmak istersem :
//for (int i = 0; i < 7; i++)
//{
//    Console.WriteLine(sayilar[i]);  
//}
/*
 * int i = index 0 dan başladığı için 0
 * i < 7 = çünkü dizi index sayısı 6 eğer i<= 7 deseydim HATA alırıdım. 
 * i++ = 1 arsın istediğim için 
 */


// Dizilerle Beraber Karar Yapısı Kullanımı

//int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
//for (int i = 0; i < sayilar.Length; i++)
{
    //if (sayilar[i] % 20 == 0) // sayilar dizisinde 20 ye tam bölünen elemanları bulmak 
    //{ 
    //Console.WriteLine(sayilar[i]);
    //}

    //if (sayilar[i] % 20 == 0 && sayilar[i] % 30 == 0)
    //{
    //    Console.WriteLine(sayilar[i]);
    //}
    //// output : 60   -> && (VE)

    //if (sayilar[i] % 20 == 0 || sayilar[i] % 30 == 0)
    //{
    //    Console.WriteLine(sayilar[i]);
    //}
    //// output : 20 30 40 60 80 90    -> || (VEYA)
}
// sayilar.Length : dizi adı. uzunluğu otomatik veririr


// Length Komutu Kullanımı

//string[] kisiler = { "fatma", "tugce", "basak", "metehan", "burce" };
//for (int i = 0; i < kisiler.Length; i++)
//{
//    Console.WriteLine(kisiler[i]);  
//}
/*
 * kisiler dizisinde ındex sayısı 4 bu yüzden for döngüsüne i < 5 ; yazarsam da olur.
 * ancak çok büyük değerlerde bunu sayamam. Bu yüzden i < kisiler.Length; yazmalıyım.
 * i < kisiler.Length; : kişler dizisinin uzunluğu demektir.
 */

//Console.WriteLine(kisiler.Length); 
//// kisiler dizisinin uzunluğunu yazar.
//// output : 5 


// Dizilerde Toplama İşlemi 

/*
 *  toplama işleme += yaklaşımı ile gerçekleşir.
 *  başlangışta ilk değeri 0 olan bir toplam değişkeni tanımlanır.
 *  toplam değişkenin son değerin üzerine, ilgili indexte bulnan değer eklenir
 *  
 *  dizi []{ 10, 20, 30, 40, 50, 60, 70, 80, 90, 100}
 *  index :  0    1   2   3   4   5   6   7   8    9   
 *  Başlangıç : toplam = 0
 *  adım 1 : 0 + 10 = 10
 *  adım 2 : 10 + 20 = 30
 *  adım 3: 30 + 30 = 60
 *  adım 4 : 60 + 40 = 100
 *  adım 5 : 100 + 50 = 150
 *         : toplamın son değeri + index değeri 
 */
//Console.WriteLine("Dizilerde Toplama İşlemi");
//Console.WriteLine();
//int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
//int toplam = 0; 
//for (int i = 0; i < sayilar.Length; i++)
//{
//    toplam += sayilar[i];
//    Console.WriteLine(toplam);// * AŞAMALARI YAZDIRIR
//}
//Console.Write("TOPLAM : "); // * SONUCU YAZDIRIR
//Console.WriteLine(toplam);
///* OUTPUT : 
// * 10 
// * 30 
// * 60 
// * 100 
// * 150 
// * 210 
// * 280 
// * 360 
// * 450 
// * 550  
// ** TOPLAM: 550
// */


// Dizi Metotları 
/*
 * SHORT    : Diziyi küçükten büyüğe sıralar.
 * REVERSE  : Diziyi tersten yazdırır.
 * INDEX OF : Aranan değerin index sırasını döndürür.
 * MAX      : Dizideki en büyük elemanı verir.
 * MİN      : Dizideki en küçük elemanı verir
 * LENGTH   : Dizinin boyutunu verir.
 */

// SHORT Metodu
//int[] sayilar = { 20, 14, 12, 35, 13 };
//Array.Sort(sayilar);
//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.WriteLine(sayilar[i]);
//}
///* Output :
//12
//13
//14
//20
//35
// */

// REVERSE Metodu

//string[] sehirler = { "mersin", "giresun", "ankara", "melbourne","istanbul", "sanfrancisco"  };
//Array.Reverse(sehirler);
//for (int i = 0; i < sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}
///* OUTPUT :
//sanfrancisco
//istanbul
//melbourne
//ankara
//giresun
//mersin
//*/

//string[] sehirler = { "mersin", "giresun", "ankara", "melbourne", "istanbul", "sanfrancisco" };
//Array.Sort(sehirler);
//Array.Reverse(sehirler);
//for (int i = 0; i < sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}
///* output:
//sanfrancisco
//mersin
//melbourne
//istanbul
//giresun
//ankara
//*/

// İNDEX OF Metodu

//string[] kisiler = { "fatma", "tugce", "basak", "metehan", "burce" };
//int sıra;
//sıra = Array.IndexOf( kisiler, "basak");
//Console.WriteLine(sıra);

//// output : 2

//string[] kisiler = { "fatma", "tugce", "basak", "metehan", "burce" };
//int sıra;
//Array.Sort(kisiler);
//sıra = Array.IndexOf(kisiler, "basak");
//Console.WriteLine(sıra);

//// output : 0

// MİN - MAX Metotları

//int[] sayilar = { 76, 43, 12, 56, 34 };
//Console.WriteLine( "en küçük sayı : " + sayilar.Min());
//Console.WriteLine("en büyük sayı : " + sayilar.Max());
//// output :
//// en küçük sayı : 12
//// en büyük sayı : 76

// Foreach Döngüsü
/*
 * Dizilerle beraber kullanılan döngü türüdür.
 * 4 temel parametersi vardır.
 *  1: değişken türü -> dizinin değişken türü ile aynı olmak zorunda
 *  2: değişken adı
 *  3: in (içinde) komutu
 *  4: dizi adı
 */

//string[] sehirler = { "ankara", "adana", "bursa", "izmir" };
//foreach (string s in sehirler)
//{
//    Console.WriteLine(s);
//}
//// s değişkeni sırasıyla dizinin elemanların üzerine çekiyor
//// extran boyut bildirmiyoruz kendisi otomatik duruyor

// Foreach Döngüsü ve Aritmetik İşlemler

//int[] sayilar = { 23, 55, 32, 16, 89, 70 };
//int toplam = 0;
//foreach(int x in sayilar)
//{
//    toplam = toplam + x;
//}
//Console.WriteLine( "Toplam: " + toplam);

//int[] sayilar = { 34, 22, 11, 67, 89, 50 };
//int toplam = 0;
//foreach (int i in sayilar)
//{
//    if (i % 2 == 0)
//    {
//     Console.WriteLine(i);
//    }
//}
//Array.Sort(sayilar); // -> odev 

// Diziye Klavyeden Değer Girişi

//string[] sehirler = new string[5];
//for (int i = 0; i < 5; i++)
//{ 
//    Console.WriteLine( "Şehir isimi : ");
//    sehirler[i] = Console.ReadLine();
//}
//for(int f = 0; f< 5; f++)
//{
//    Console.WriteLine();    
//    Console.WriteLine(sehirler[f] );    
//}
