// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
// и последнюю строку массива.
Console.WriteLine("Введите количество строк m массива:");
byte rows = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n массива:");
byte columns = Convert.ToByte(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] arr = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(10);
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
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int[,] array = GetArray(rows, columns);
PrintArray(array);

int [,] ReplaceRows(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int i = 0;
        int temp = arr[i, j];
        arr[i, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }
    return arr;
}

int [,] newArray = ReplaceRows(array);
System.Console.WriteLine();
PrintArray(newArray);
