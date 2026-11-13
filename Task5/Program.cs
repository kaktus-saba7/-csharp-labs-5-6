const int nomer = 2;
const int n = 5;

int[,] matrix = GenerateMatrix(n, nomer);

Console.WriteLine("Бастапқы матрица:");
PrintMatrix(matrix);

int[] B = FindMaxElements(matrix);

Console.WriteLine("\nӘр бағандағы ең үлкен элементтер:");
PrintArray(B);

static int[,] GenerateMatrix(int n, int nomer)
{
    int[,] m = new int[n, n];
    Random random = new Random(nomer);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            m[i, j] = random.Next(-10, 11);
        }
    }

    return m;
}
static void PrintMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write($"{m[i, j],4}");
        }

        Console.WriteLine();
    }
}

static int[] FindMaxElements(int[,] m)
{
    int rows = m.GetLength(0);
    int columns = m.GetLength(1);

    int[] B = new int[columns];

    for (int j = 0; j < columns; j++)
    {
        int max = m[0, j];

        for (int i = 1; i < rows; i++)
        {
            if (m[i, j] > max)
            {
                max = m[i, j];
            }
        }

        B[j] = max;
    }

    return B;
}

static void PrintArray(int[] B)
{
    for (int i = 0; i < B.Length; i++)
    {
        Console.Write(B[i] + " ");
    }

    Console.WriteLine();
}