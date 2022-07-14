//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
Console.Write("Введите количество строк m: ");
byte rows = Convert.ToByte(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
byte columns = Convert.ToByte(Console.ReadLine());

int[,] CreateArray(int m, int n)
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

int[,] myArray = CreateArray(rows, columns);
System.Console.WriteLine();
PrintArray(myArray);


int[] row = new int[myArray.GetLength(0)];

for (int i = 0; i < myArray.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        sum += myArray[i, j];
    }
    row[i] = sum;
}

System.Console.WriteLine();
PrintOneArray(row);
Console.WriteLine($"Строка {FindIndexMin(row)} массива с наименьшей суммой элементов {row[FindIndexMin(row)]}");


void PrintOneArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "  ");
    }
    System.Console.WriteLine();
}

int FindIndexMin(int[] arr)
{
    int imin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < arr[imin]) imin = i;
    }
    return imin;
}

