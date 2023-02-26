// See https://aka.ms/new-console-template for more information
int[] sayilar = { 2, 5, 7, 12, 55, 99 };
int enbuyuk = sayilar[0];
for (int i = 1; i < sayilar.Length; i++)
{
    if (sayilar[i] > enbuyuk)
    {
        enbuyuk = sayilar[i];

    }
}
Console.WriteLine("En buyuk sayi : " + enbuyuk);
