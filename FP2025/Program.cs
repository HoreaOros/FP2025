// Kollatz sequence

// This program calculates
// the Collatz sequence for a given positive integer.


int maxLen = 0;
int maxNo = 0;

for (int n = 1; n <= 1000; n++)
{
    int len = K(n);
    
    if(len >  maxLen )
    {
        maxLen = len;
        maxNo = n;
    }
}

Console.WriteLine($"Cea mai lunga secventa are lungimea {maxLen} si se obtine pentru numarul {maxNo}");

int K(int n)
{
    int length = 1;
    Console.Write($"{n} ");
    while (n != 1)
    {
        length++;
        if (n % 2 == 0) 
            n = n / 2; 
        else 
            n = 3 * n + 1;
        Console.Write($"{n} ");
    }
    Console.WriteLine();
    Console.WriteLine();


    return length;
}

// side effect






