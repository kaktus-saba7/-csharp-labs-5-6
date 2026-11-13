const int nomer = 2;
const int n = 5;

// Матрицаны құру
int[,] matrix = GenerateMatrix(n, nomer);

// Матрицаны шығару
Console.WriteLine("Бастапқы матрица:");
PrintMatrix(matrix);

// Әр бағандағы ең үлкен элементтерді табу
int[] B = FindMaxElements(matrix);

// Нәтижені шығару
Console.WriteLine("\nӘр бағандағы ең үлкен элементтер:");
PrintArray(B);


// Матрицаны құру әдісі
static int[,] GenerateMatrix(int n, int nomer)
{
    int[,] m = new int[n, n];
    Random random = new Random(nomer);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            m[i, j] = random.Next(0, 100);
        }
    }

    return m;
}


// Матрицаны экранға шығару әдісі
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


// Әр бағандағы ең үлкен элементті табу әдісі
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


// B массивін экранға шығару әдісі
static void PrintArray(int[] B)
{
    for (int i = 0; i < B.Length; i++)
    {
        Console.Write(B[i] + " ");
    }

    Console.WriteLine();
}