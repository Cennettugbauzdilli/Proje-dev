// See https://aka.ms/new-console-template for more information
using Ödevvv;
using static Ödevvv.Mersedes;

Console.WriteLine("Hello, World!");
Arabacs a = new Arabacs();
a.marka = "BMW";
a.model = "X5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.git("Mercedes", "XL");
a.git(a.marka, a.model);

BWM bm = new BWM();
bm.markaModelYaz("Bmw", "X5");

Mersedes me = new Mersedes();
me.markaModelYaz("Mercedes", "XL");
