// See https://aka.ms/new-console-template for more information

Console.WriteLine("Sinav puani gir : ");
int puan= Convert.ToInt32(Console.ReadLine());
char HarfNotu = 'A';

for(int i=0;i<100;i++)
{
}
if (puan >= 91 && puan <= 100)
    {
        HarfNotu = 'A';
    }
    else if (puan >= 81 && puan <= 90)
    {
        HarfNotu = 'B';
    }
    else if (puan >= 71 && puan <= 80)
    {
        HarfNotu = 'C';
    }
    else if (puan >= 61 && puan <= 70)
    {
        HarfNotu = 'D';
    }
    else if (puan >= 51 && puan <= 60)
    {
        HarfNotu = 'E';
    }
    else
    {
        HarfNotu = 'F';
    }
    Console.WriteLine("Sinav Notunuz : "+HarfNotu);

