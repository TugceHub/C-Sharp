// Random Sınıfı
/*
 * Kod kısımında belirlenen aralıklarda rastgele olarak tam sayı üreten sınıftıç
 * Random nesne_adı = new Random();
 * Değer aralığı : Next
 */

// Random Örnek 

//int sayi;
//Random r = new Random();
//sayi = r.Next(0, 51); // min * max -> minde yazdığın değer dahildir ancak maxta deüildir yani maksta 51 yazdık diye 51 karşımıza çıkmaz max : 50 çıkar
//Console.WriteLine(sayi);

// Random Sınıfı ile Dizi Kullanımları

//int sayi, sayi2;
//Random r = new Random();
//sayi = r.Next(0, 51);
//sayi2 = r.Next(0, 51);  // 2 si daima farklı gelir.
//Console.WriteLine(sayi + " " + sayi2);

// Random Sınıfında Dizi Kullanımı

//Random rn = new Random();
//int sehir;
//string[] sehirler = { "Mersin", "İstanbul", "Sidney", "Melbourne" };
//sehir = rn.Next(0, sehirler.Length);
//Console.WriteLine(sehirler[sehir]);


// Captcha Oluşturma
//using System.Collections.Specialized;

//int d1, d2, d3, d4;
//Random rnd = new Random();
//d1 = rnd.Next(0, 10);
//d2 = rnd.Next(0, 10);
//d3 = rnd.Next(0, 10);
//d4 = rnd.Next(0, 10);
//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);
//Console.WriteLine(d4);
//Console.WriteLine();
//String[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
//Console.WriteLine(d1 + karakterler[d2] + d3 + karakterler[d4]);






