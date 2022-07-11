// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку
//и столбец, на пересечении которых расположен наименьший элемент массива.

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
            arr[i, j] = rnd.Next(100);
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

int[,] DelRowColumn(int[,] arr)
{

    int imin = 0;
    int jmin = 0;
    //int min = arr[imin, jmin];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[imin, jmin] > arr[i, j])
            {
                imin = i;
                jmin = j;
            }
        }
    }


    int[,] copy = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int k = 0; k < arr.GetLength(0) - 1; k++)
    {
        for (int m = 0; m < arr.GetLength(1) - 1; m++)
        {
            int flagK;
            int flagM;
            if (k >= imin) flagK = 1;
            else flagK = 0;
            if (m >= jmin) flagM = 1;
            else flagM = 0;
            copy[k, m] = arr[k + flagK, m + flagM];
        }
    }
    return copy;

}

int[,] newArr = DelRowColumn(array);
System.Console.WriteLine();
PrintArray(newArr);

void FindMin(int[,] arr)
{
    int imin = 0;
    int jmin = 0;
    int min = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[imin, jmin] > arr[i, j])
            {
                imin = i; 
                jmin = j;
                min = arr[i, j];

            }
        }
    }
    System.Console.WriteLine($"min = {min}, imin = {imin}, jmin = {jmin}");
    // return min; 
}
FindMin(array);
