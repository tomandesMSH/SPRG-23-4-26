int[] cisla = new int[5];

for (int cislo = 0; cislo < 5; cislo++)
{
    Console.Write("Zadej číslo " + (cislo + 1) + ": ");
    cisla[cislo] = int.Parse(Console.ReadLine()!);
}

int max = cisla[0];
for (int i = 1; i < 5; i++)
{
    if (cisla[i] > max) max = cisla[i];
}

Console.WriteLine("Nejvyšší hodnota je: " + max);