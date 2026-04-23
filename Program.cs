Console.WriteLine("Zadej dvě čísla na nasledujici radky: ");
int cislo = int.Parse(Console.ReadLine());
int cislo2 = int.Parse(Console.ReadLine());
int porovnej(int cislo, int cislo2)
{
    if (cislo > cislo2)
    {
        return 1;
    }
    else if (cislo < cislo2)
    {
        return 2;
    }
    else
    {
        return 0;
    }
};

switch (porovnej(cislo, cislo2))
{
    case 1:
        Console.WriteLine("Větší číslo je: " + cislo);
        break;
    case 2:
        Console.WriteLine("Větší číslo je: " + cislo2);
        break;
    default:
        Console.WriteLine("Čísla jsou stejná.");
        break;
}