// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива. 
Console.Write("Введите количество строк m: ");
byte rows = Convert.ToByte(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
byte columns = Convert.ToByte(Console.ReadLine());

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

int[,] myArray = CreateArraay(rows, columns);
System.Console.WriteLine();
PrintArray(myArray);

int[,] SortEveryRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int jmax = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, jmax] < array[i, k])
                {
                    jmax = k;
                }
            }
            int temp = array[i, jmax];
            array[i, jmax] = array[i, j];
            array[i, j] = temp;
        }
    }
    return array;
}

myArray = SortEveryRows(myArray);
System.Console.WriteLine();
PrintArray(myArray);






