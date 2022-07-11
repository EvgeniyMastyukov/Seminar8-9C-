// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных.
// Набор данных                Частотный массив
// 1, 2, 3                1 встречается 3 раза
// 4, 6, 1                2 встречается 2 раз
// 2, 1, 6                3 встречается 1 раз
//                        4 встречается 1 раз
//                        6 встречается 2 раза

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

// string[] str = new string[count];


for (int i = 0; i < array.GetLength(0); i++)
{
    int count = 0;
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {

        int n = 0;
        if (array[i, j] == array[i, j + 1]) 
        {
           count += 2;
            string[] str = new string[n + 1];
            for (int k = 0; k < str.Length; k++)
            {
                str[k] = $"{array[i, j]}  встречается {count}  раз";
                n++;
                Console.WriteLine(str[k]);
            }
        }
        else
        {
            string[] str = new string[n + 1];
            for (int k = 0; k < str.Length; k++)
            {
                str[k] = $"{array[i, j+1]}  встречается {count}  раз";
                n++;
                Console.WriteLine(str[k]);
            }
        }




    }
}
