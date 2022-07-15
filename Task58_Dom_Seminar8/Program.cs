//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк m матрицы А: ");
byte rowsA = Convert.ToByte(Console.ReadLine());
Console.Write("Введите количество столбцов n матрицы А : ");
byte columnsA = Convert.ToByte(Console.ReadLine());

Console.Write("Введите количество строк n матрицы B: ");
byte rowsB = Convert.ToByte(Console.ReadLine());
Console.Write("Введите количество столбцов r матрицы B : ");
byte columnsB = Convert.ToByte(Console.ReadLine());

int[,] CreateArraay(int m, int n)
{
    Random random = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrixA = CreateArraay(rowsA, columnsA);
System.Console.WriteLine();
PrintArray(matrixA);

int[,] matrixB = CreateArraay(rowsB, columnsB);
System.Console.WriteLine();
PrintArray(matrixB);

int[,] FindProductMatrix(int[,] matA, int[,] matB)
{
    int[,] product = new int[matA.GetLength(0), matB.GetLength(1)]; // Amn * Bnr = Cmr
    for (int i = 0; i < matA.GetLength(0); i++) // движемся по строке
    {
        for (int k = 0; k < matB.GetLength(1); k++) // движемся по столбцам
        {
            int sum = 0;
          
            for (int j = 0; j < matB.GetLength(0); j++) //matB.GetLength(0) == matA.GetLength(1)
            {
                sum += matA[i, j] * matB[j, k]; 
            }
            product[i, k] = sum;         

        }
    }
    return product;
}

int[,] resalt = FindProductMatrix(matrixA, matrixB);
System.Console.WriteLine();
PrintArray(resalt);
