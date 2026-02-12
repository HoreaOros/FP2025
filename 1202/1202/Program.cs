// MATRICI

#region Input parsing
string text = File.ReadAllText("input.txt");
string[] t = text.Split(Environment.NewLine + Environment.NewLine);

int[,] m1 = ParseMatrix(t[0]);
int[,] m2 = ParseMatrix(t[1]);

PrintMatrix(m1);
PrintMatrix(m2);

// TODO:
// parcurgerea unei matrici in spirala
Spirala(m1);
Spirala(m2);

PrintMatrix(Pattern(3));

int[,] Pattern(int n)
{
    int[,] m = new int[1 << n, 1 << n];
    GenPattern(m, n, 0, 0, (1 << n) - 1, (1 << n) - 1);
    return m;

}

void GenPattern(int[,] m, int n, int i1, int j1, int i2, int j2)
{
    if (n == 0)
        return;
    int i3 = (i1 + i2) / 2;
    int j3 = (j1 + j2) / 2;
    for (int i = i1; i <= i3; i++)
        for (int j = j1; j <= j3; j++)
            m[i, j] = 1;

    GenPattern(m, n - 1, i1, j3 + 1, i3, j2);
    GenPattern(m, n - 1, i3 + 1, j1, i2, j3);
    GenPattern(m, n - 1, i3 + 1, j3 + 1, i2, j2);

}

void Spirala(int[,] m)
{
    int i1 = 0;
    int j1 = 0;
    int i2 = m.GetLength(0) - 1;
    int j2 = m.GetLength(1) - 1;
    int k = 0;
    while (true)
    {
        for (int j = j1; j <= j2; j++)
        {
            Console.WriteLine($"{m[i1, j]} ");
            k++;
        }
        i1++;
        if (k == m.Length)
            break;
        for (int i = i1; i <= i2; i++)
        {
            Console.WriteLine($"{m[i, j2]} ");
            k++;
        }
        j2--;
        if (k == m.Length)
            break;
        for (int j = j2; j >= j1; j--)
        {
            Console.WriteLine($"{m[i2, j]} ");
            k++;
        }
        i2--;
        if (k == m.Length)
            break;
        for (int i = i2; i >= i1; i--)
        {
            Console.WriteLine($"{m[i, j1]} ");
            k++;
        }
        j1++;
        if (k == m.Length)
            break;
    }

    Console.WriteLine();
}

// Matrici patratice
// Suma elementelor de pe diagonala principala (i == j)

int Suma_diagP(int[,] m)
{
    int Suma = 0;
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i == j) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor de pe diagonala principala a primei matrici este {Suma_diagP(m1)}");
Console.WriteLine($"Suma elementelor de pe diagonala principala al doilea matrici este {Suma_diagP(m2)}");


// Suma elementelor de pe diagonala secundara (i+j == n - 1)

int Suma_diagS(int[,] m)
{
    int Suma = 0;
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i+j == m.GetLength(0)-1) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor de pe diagonala secundara a primei matrici este {Suma_diagS(m1)}");
Console.WriteLine($"Suma elementelor de pe diagonala secundara al doilea matrici este {Suma_diagP(m2)}");

// Suma elementelor de deasupra diagonalei principale (i < j)

int Suma_deasupra_diagP(int[,] m)
{
    int Suma = 0;

    for(int i=0;i<m.GetLength(0);i++)
        for(int j=0;j<m.GetLength(1);j++)
            if(i<j) Suma += m[i,j];

    return Suma;
}

Console.WriteLine($"Suma elementelor de deasupra diagonala principala a primei matrici este {Suma_deasupra_diagP(m1)}");
Console.WriteLine($"Suma elementelor de deasupra diagonala principala al doilea matrici este {Suma_deasupra_diagP(m2)}");

// Suma elementelor de sub diagonala principala 

int Suma_sub_diagP( int[,] m)
{
    int Suma = 0;

    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i > j) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor de sub diagonala principala a primei matrici este {Suma_sub_diagP(m1)}");
Console.WriteLine($"Suma elementelor de sub diagonala principala al doilea matrici este {Suma_sub_diagP(m2)}");

// Suma elementelor de deasupra diagonalei secundare

int Suma_deasupra_diagS(int[,] m)
{
    int Suma = 0;

    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i + j < m.GetLength(0) - 1) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor de pe deasupra diagonalei secundare a primei matrici este {Suma_deasupra_diagS(m1)}");
Console.WriteLine($"Suma elementelor de pe deasupra diagonalei secundare al doilea matrici este {Suma_deasupra_diagS(m2)}");

// Suma elementelor de sub diagonala secundare 

int Suma_sub_diagS( int[,] m)
{
    int Suma = 0;

    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i + j > m.GetLength(0) - 1) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor de sub diagonalei secundare a primei matrici este {Suma_sub_diagS(m1)}");
Console.WriteLine($"Suma elementelor de sub diagonalei secundare al doilea matrici este {Suma_sub_diagS(m2)}");

// Suma elementelor din zona de Nord a matricii

int Suma_Nord(int[,] m)
{
    int Suma = 0;
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i < j && i + j < m.GetLength(0) - 1)
            {
                Suma += m[i, j];
            }

    return Suma;
}

Console.WriteLine($"Suma elementelor din zona de Nord a primei matrici este {Suma_Nord(m1)}");
Console.WriteLine($"Suma elementelor din zona de Nord al doilea matrici este {Suma_Nord(m2)}");

// Suma elementelor din zona de Sud a matricii

int Suma_Sud(int[,] m)
{
    int Suma = 0;
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i > j && i + j > m.GetLength(0) - 1) Suma += m[i, j];
        return Suma;
}

Console.WriteLine($"Suma elementelor din zona de Sud a primei matrici este {Suma_Sud(m1)}");
Console.WriteLine($"Suma elementelor din zona de Sud al doilea matrici este {Suma_Sud(m2)}");

// Suma elementelor din zona de Est a matricii s

int Suma_Est(int[,] m)
{
    int Suma = 0;
    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if(i<j &&  i + j > m.GetLength(0)-1) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor din zona de Est a primei matrici este {Suma_Est(m1)}");
Console.WriteLine($"Suma elementelor din zona de Est al doilea matrici este {Suma_Est(m2)}");

// Suma elementelor din zona de Vest a matricii

int Suma_Vest(int[,] m)
{
    int Suma = 0;

    for (int i = 0; i < m.GetLength(0); i++)
        for (int j = 0; j < m.GetLength(1); j++)
            if (i > j && i + j < m.GetLength(0) - 1) Suma += m[i, j];

    return Suma;
}

Console.WriteLine($"Suma elementelor din zona de Vest a primei matrici este {Suma_Vest(m1)}");
Console.WriteLine($"Suma elementelor din zona de Vest al doilea matrici este {Suma_Vest(m2)}");


// Parcurgere pe diagonala
//4 4
//1  3  4 10
//2  5  9 11
//6  8 12 15
//7 13 14 16
// se va afisa: 1 2 3 ... 16

// Parcurgere concentrica
// 1  2  9 10
// 4  3  8 11
// 5  6  7 12
//16 15 14 13
//  se va afisa: 1 2 3 ... 16

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] ParseMatrix(string str)
{
    string[] lines = str.Split(Environment.NewLine);
    string[] t2 = lines[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
    //int LIN = int.Parse(t2[0]);
    //int COL = int.Parse(t2[1]);
    int LIN, COL;
    int.TryParse(t2[0].Trim(), out LIN);
    int.TryParse(t2[1].Trim(), out COL);
    int[,] matrix = new int[LIN, COL];
    for (int i = 0; i < LIN; i++)
    {
        t2 = lines[i + 1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < t2.Length; j++)
            matrix[i, j] = int.Parse(t2[j]);
    }
    return matrix;
}

#endregion
