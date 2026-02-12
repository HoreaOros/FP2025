



#region Palindrom
// Palindrom



//Oglindit(12345);

//VerificarePalindrom(Palindrom1);
//VerificarePalindrom(Palindrom2);


// 121  ; 123;,456;12321
using System.Diagnostics;



void VerificarePalindrom(Func<string, bool> checkPalindrom)
{
    string line = Console.ReadLine();
    char[] seps = { ' ', ',', ';' };
    string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);


    foreach (string token in tokens)
    {
        if (checkPalindrom(token))
            Console.WriteLine($"{token} este palindrom");
        else
            Console.WriteLine($"{token} nu este palindrom");
    }
}


bool Palindrom1(string token)
{
    string reverse = new string(token.Reverse().ToArray());
    return token == reverse;
}


bool Palindrom2(string token)
{
    int nr = int.Parse(token);

    return nr == Oglindit(nr);
}

int Oglindit(int nr)
{
    int ogl = 0;
    while (nr > 0)
    {
        int cifra = nr % 10;
        nr /= 10;

        ogl = ogl * 10 + cifra;
    }
    return ogl;
}
#endregion


#region Sort3
static void Sort3()
{
    int a, b, c;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());

    int minim = a;
    if (b < minim)
        minim = b;
    if (c < minim)
        minim = c;

    //minim = Math.Min(a, Math.Min(b, c));


    int maxim = a;
    if (b > maxim)
        maxim = b;
    if (c > maxim)
        maxim = c;

    //int maxim = Math.Max(a, Math.Max(b, c));

    int median = (a + b + c) - (minim + maxim);
    Console.WriteLine($"{minim} {median} {maxim}");
}

#endregion


#region Divizori
int n = 1000000000;

Stopwatch sw = new Stopwatch();
sw.Start();
Console.WriteLine($"Suma divizorilor lui {n} este {SumaDivizori4(n)}");
sw.Stop();
Console.WriteLine($"Timpul de executie: - {sw.Elapsed}");
// 100 ==> 1, 2, 4, 5, 10, 20, 25, 50, 100
sw.Reset();


// O(sqrt(n))
long SumaDivizori3(int n)
{
    long suma = 0;
    int d = 0;
    for (d = 1; d * d < n; d++)
        if (n % d == 0)
            suma = suma + d + n / d;

    if (d * d == n)
        suma += d;
    return suma;
}


// TODO
// n = p1^a * p2^b * p3^c;
// 60 = 2^2 * 3^1 *  5^1;
// d | n ==> d = p1^q1 * p2^q2 * p3^q3; (a+1)*(b+1)*(c+1);
// SD(n) = (1+p1+...p1^a) * (1+p2+...p2^b) * (1+p3+...p3^c)

long SumaDivizori4(int n)
{
    long suma = 1;
    int d = 2;

    while(n!=1)
    {
        long SumaPartial = 1,p=1;
        
            while(n%d==0)
            {
                n = n / d;
                p = p * d;
                SumaPartial=SumaPartial + p;
            }

        suma = suma * SumaPartial;
        d++;
    }
    return suma;
}

// O(n)
long SumaDivizori2(int nr)
{
    long suma = 1 + n;

    for (int d = 2; d <= nr / 2; d++)
    {
        if (nr % d == 0)
            suma += d;
    }

    return suma;
}


// O(n)
long SumaDivizori1(int nr)
{
    long suma = 0;

    for (int d = 1; d <= n; d++)
    {
        if (nr % d == 0)
            suma += d;
    }

    return suma;
}
#endregion
