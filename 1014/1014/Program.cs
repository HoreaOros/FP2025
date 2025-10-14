
//P1();



P2();

static bool ExtractNumber(out int n)
{
    Console.WriteLine("Introduceti un numar natural: ");
    string line;
    line = Console.ReadLine();
    try
    {
        n = int.Parse(line);
    }
    catch (FormatException)
    {
        Console.WriteLine("Nu s-a introdus un numar");
        n = -1;
        return false;
    }

    return true;
}


///<summary>
/// Functia calculeaza suma primelor n numere naturale nenule
/// S = 1 + 2 + ... + n
/// O(1)
///</summary>
void P2()
{
    int n;
    bool flowControl = ExtractNumber(out n);
    if (!flowControl)
    {
        return;
    }


    long suma = (long)n * (n + 1) / 2;
    Console.WriteLine($"Suma numerelor de la 1 la {n} este egala cu {suma}");

}



///<summary>
/// Functia calculeaza suma primelor n numere naturale nenule
/// S = 1 + 2 + ... + n
/// O(n) - algoritm liniar
///</summary>
void P1()
{
    int n;
    bool flowControl = ExtractNumber(out n);
    if (!flowControl)
    {
        return;
    }

    long suma = 0;
    for (int i = 1; i <= n; i++)
        checked
        {
            suma = suma + i;
        }

    Console.WriteLine($"Suma numerelor de la 1 la {n} este egala cu {suma}");

}