// See https://aka.ms/new-console-template for more information
int pozitif = 0;
int negatif = 0;

Random rnd = new Random();

int[] sayilar = { 2, -45, -56, 8, 90, 23 };

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(-57, 91);
}

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
    if (sayi > 0)
    {
        pozitif++;
    }
    else
    {
        negatif++;
    }
}
Console.WriteLine("Pozitif Sayı Adeti :  " + pozitif);
Console.WriteLine("Negatif Sayı Adeti :  " + negatif);
