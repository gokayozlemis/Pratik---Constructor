using System;

class bebek
{

    public DateTime DogumTarihi { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public bebek()
    {
        Console.WriteLine("Ingaaaa");
        DogumTarihi = DateTime.Now; 
    }
    public bebek(string ad, string soyad) : this() 
    {
        Ad = ad;
        Soyad = soyad;
    }
}
class Program
{
    static void Main(string[] args)
    {
        bebek bebek1 = new bebek();
        Console.WriteLine("Bebek1 - Ad: {0}, Soyad: {1}, Dogum Tarihi: {2}",
                          bebek1.Ad ?? "Bilgi Yok", bebek1.Soyad ?? "Bilgi Yok", bebek1.DogumTarihi);

        bebek bebek2 = new bebek("Ahmet", "Yılmaz");
        Console.WriteLine("Bebek2 - Ad: {0}, Soyad: {1}, Dogum Tarihi: {2}",
                          bebek2.Ad, bebek2.Soyad, bebek2.DogumTarihi);
    }
}
