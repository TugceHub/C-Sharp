// Sınıflar ve Nesneler
// Nesne Nedir?
//    SınıfAdı NesneAdı = new SınıfAdı();

// Uygulama: Araba Sınıfı

using sınıflarVeNesneler;

class program
{
    static void Main(string[] args)
    {
        Araba ar = new Araba();
        ar.marka = "ferrai";
        ar.hiz = 200;
        ar.renk = "lacivert";
        ar.motor = 2.0;

        Müşteri mu = new Müşteri();
        mu.id = 1881;
        mu.name = "Fatma ";
        mu.surname = "BULUT";
        mu.city = "Ankara";

        Console.WriteLine("*********** ARABA TANTIM KARTI 1 ************");
        Console.WriteLine();
        Console.WriteLine("Marka : " + ar.marka);
        Console.WriteLine("Hız : " + ar.hiz);
        Console.WriteLine("Renk : " + ar.renk);
        Console.WriteLine("Motor : " + ar.motor);

        Console.WriteLine("*********** Müşteri Bilgisi ************");
        Console.WriteLine();
        Console.WriteLine("Ad Soyad : " + mu.id +" - "+ mu.name + mu.surname);
        Console.WriteLine("Şehir : " + mu.city);
        Console.WriteLine();
        Console.WriteLine();

        mu.id = 1938;
        mu.name = "Beyza Basak ";
        mu.surname = "BULUT";
        mu.city = "Ankara";
        Console.WriteLine("Ad Soyad : " + mu.id + " - " + mu.name + mu.surname);
        Console.WriteLine("Şehir : " + mu.city);

    }

}