//P1();
//P2();
//P3();
//P4();
//P5();
//P6();

//D1(10);
//D2(10);
//D4(9);

L1(6);


/// <summary>
/// 1- 1
/// 2- 1 1
/// 3- 2 1
/// 4- 1 2 1 1
/// 5- 1 1 1 2 2 1
/// 6- 3 1 2 2 1 1
/// 7- 1 3 1 1 2 2 2 1 
/// 8- 1 1 1 3 2 1 3 2 1 1
/// </summary>
/// <param name="n">numarul de linii care se afiseaza</param>
static void L1(int n)
{

    int x = 1; // dimensiunea vectorului 
    int[] v= new int[10000000]; // vectorul 
    v[0] = 1; // primul element din vector 

    Console.WriteLine(v[0]); // afisarea primei linii

    for (int i = 1; i < n; i++) 
    {

        if (i == 1)
        {
            x++;
            v[0] = 1;
            v[1] = 1;
            Console.Write($"{v[0]} {v[1]}");
            Console.WriteLine();
        }
        else
        {
            int nr , p1, p2, g,p=0;

            while (p < x)
            {
                g = 0; nr = 1;p1 = 0;p2 = 0;

                // se parcurge for-ul pentru a numara cate numere sunt consecutive 

                for (int j = p; j < x - 1; j++)
                {
                    if (v[j] == v[j + 1])
                    {
                        if (g == 0)
                        {
                            g = v[j];
                        }
                        if (nr == 1) p1 = j;
                        nr++;
                        p = j;
                        p2= j + 1;
                    }
                    else
                    {
                        break;
                    }

                }

                // crearea al treilea linie 
                if(p2-p1==1)
                {
                    v[p2] = v[p1]; 
                    v[p1] = nr;
                    p = p1 + 2;

                }
                else if(p2-p1>1)
                {
                    v[p1] = nr;
                    v[p1 + 1] = g; 


                    for (int d = p1 + 2; d < x; d++)
                        v[d] = v[d + 1];
                    x = x - p2 + 1;

                   
                    p = p1 + 2;
                }

                if (nr == 1)
                {
                    for (int d = x; d > p; d--)
                        v[d] = v[d - 1];
                    x++;
                    v[p] = nr;
                    p = p + 2;
                   
                }
            }
           
            for (int h = 0; h < x; h++)
                    Console.Write($"{v[h]} ");
                Console.WriteLine();
        }
    }
}

/// <summary>
/// *******
/// *** ***
/// **   **
/// *     *
/// **   **
/// *** ***
/// *******
/// </summary>
/// <param name="v">v trebuie sa fie impar</param>
/// <exception cref="NotImplementedException"></exception>
//sper ca v este numarul de linii si probabil ca este
//defapt pare ca v este si numarul maxim de stelute de pe o linie
static void D4(int v)
{
    
    int sp = 1; 
   for(int i=1;i<=v;i++)
    {
        if(i==1 || i==v)
        {
            string line = new string('*', v);
            Console.WriteLine(line);
        }
        else if(i<=(v/2)+1)
        {
            string line = new string('*',(v-sp)/2);
            string spa = new string(' ', sp);
            Console.Write(line);
            Console.Write(spa);
            Console.Write(line);
            Console.WriteLine();
            sp=sp+2;
        }
        else if (i > v / 2 + 1)
        {
            sp=sp-2;
            string line = new string('*', (v-sp)/2);
            string spa = new string(' ', sp);
            Console.Write(line);
            Console.Write(spa);
            Console.Write(line);
            Console.WriteLine();
        }
        
    }
}

/// <summary>
///    *
///   * *
///  *   *
/// * * * *
/// </summary>
/// <param name="n"></param>
/// <exception cref="NotImplementedException"></exception>
static void D3(int n)
{
    // prima linie
    for (int i = 0; i < n - 1; i++)
        Console.Write(' ');
    Console.WriteLine("*");

    // liniile din mijloc
    int ns1 = n - 2, ns2 = 1;
    for (int k = 2; k <= n - 1; k++)
    {
        for (int i = 0; i < ns1; i++)
            Console.Write(' ');
        Console.Write("*");
        for (int i = 0; i < ns2; i++)
            Console.Write(' ');
        Console.WriteLine("*");
        ns1--;
        ns2 += 2;
    }


    // ultima linie
    for (int i = 0; i < n; i++)
        Console.Write("* ");
    Console.WriteLine();
}

/// <summary>
/// *
/// **
/// ***
/// ****
///     ****
///      ***
///       **
///        *
/// </summary>
/// <param name="v"></param>
/// <exception cref="NotImplementedException"></exception>
static void D2(int n)
{
    D1(n);
    int n_sp = n, n_st = n;
    for (int i = 0; i < n; i++)
    {
        string spatii = new string(' ', n_sp);
        string stelute = new string('*', n_st);
        Console.WriteLine($"{spatii}{stelute}");
        n_sp++;
        n_st--;
    }
}
/// <summary>
/// n(n+1)(2n+1)(3n^2+3n−1)/30.
///1**4+2**4+...+n**4
/// </summary>
/// <exception cref="NotImplementedException"></exception>
static void P6()
{
    //TODO

}



/// <summary>
/// S = 1^3 + 2^3 +...+ n^3
/// </summary>
/// <exception cref="NotImplementedException"></exception>
static void P5()
{
    int n = 10;
    int suma = (int)Math.Pow(n * (n + 1) / 2, 2);
    Console.WriteLine(suma);
}


/// <summary>
/// S = (1^2+2^2+...+n^2) mod 1.000.000.007;
/// </summary>

static void P4()
{
    // O(1) - algoritm constant
    long n = 1000000000;
    long M = 1000000007;
    n = int.Parse(Console.ReadLine());
    //long suma = n * (n + 1) * (2 * n + 1) / 6 % M;
    long a = n;
    long b = n + 1;
    long c = (2 * n + 1);
    if (a % 2 == 0)
        a = a / 2;
    else
        b = b / 2;

    if (a % 3 == 0)
        a = a / 3;
    else if (b % 3 == 0)
        b = b / 3;
    else
        c = c / 3;

    // (a + b) mod M = (a mod M + b mod M) mod M
    // (a * b) mod M = (a mod M * b mod M) mod M
    long suma = a % M * b % M * c % M;
    Console.WriteLine(suma);
}


/// <summary>
/// S = 1^2+2^2+...+n^2;
/// </summary>
static void P3()
{
    // O(n) - algoritm liniar
    int n;
    n = int.Parse(Console.ReadLine());
    long suma = 0;
    for (int i = 1; i <= n; i++)
        suma = suma + i * i;
    Console.WriteLine(suma);
}

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


/// <summary>
/// *
/// **
/// ***
/// ****
/// </summary>
/// <exception cref="NotImplementedException"></exception>
static void D1(int n)
{
    for (int i = 1; i <= n; i++)
    {
        //string line = new string('*', i);
        //Console.WriteLine(line);
        // SAU

        for (int j = 1; j <= i; j++)
            Console.Write('*');
        Console.WriteLine();
    }
}
