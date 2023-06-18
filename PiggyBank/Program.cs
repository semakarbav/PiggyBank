// See https://aka.ms/new-console-template for more information
using PiggyBank;

Kumbara kumbara = new Kumbara(100.0);

Banknote banknote = new Banknote("Bir TL", 1);
Coin coin = new Coin("On Kuruş", 0.10m, 1.0, 1.0);


try
{
    kumbara.ParaEkle(banknote);
    kumbara.ParaEkle(coin);
}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}

Console.ReadLine();
    