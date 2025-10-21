// Test de primalitate
// 2, 3, 5, 7, 11, 13, 17, 19, ....


int n = 1000000007;
Console.WriteLine($"Numarul {n} este prim? <{IsPrime(n)}>");


ulong m = 9223372036854775783ul;
Console.WriteLine($"Numarul {m} este prim? <{IsPrimeBetter(m)}>");

// O(n)
bool IsPrime(long n)
{
    if (n < 2)
        return false;
    if(n == 2 || n == 3)
        return true;
    if(n % 2 == 0 || n % 3 == 0)
        return false;

    for(long d = 3; d <= n / 2; d += 2)
        if(n % d == 0)
            return false;

    return true;
}




// O(sqrt(n))
bool IsPrimeBetter(ulong n)
{
    if (n < 2)
        return false;
    if (n == 2 || n == 3)
        return true;
    if (n % 2 == 0 || n % 3 == 0)
        return false;

    
    for (ulong d = 3; d * d <= n; d += 2) // 
        if (n % d == 0)
            return false;

    return true;
}

var r = Prime3(24);
Console.WriteLine($"{r.result}, {r.div}");

// O(sqrt(n))
(bool result, int div) Prime3(int n)
{
    if (n < 2)
        return (false, 0);
    if (n == 2 || n == 3)
        return (true, 0);
    if (n % 2 == 0)
        return (false, 2);
    if (n % 3 == 0)
        return (false, 3);

    for (int d = 5; d * d <= n; d += 6)
        if (n % d == 0)
            return (false, d);
        else if (n % (d + 2) == 0)
            return (false, d + 2);

    return (true, 0);
}