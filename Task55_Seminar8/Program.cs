// Задача 55: Задайте двумерный массив. Напишите программу,которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int[,] ReplaceRowsOnColumns(int[,] arr)
{
    int[,] copy = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            copy[i, j] = arr[j, i];
        }
    }
    return copy;
}
Console.WriteLine();
if(rows == columns) 
{
    int[,] newArray = ReplaceRowsOnColumns(array);
    PrintArray(newArray);
}    
else  
Console.WriteLine("Используйте для замены строк формат: количество строк = количество столбцов");