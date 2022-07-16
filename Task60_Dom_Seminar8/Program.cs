//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите количество страниц k: ");
byte pages = Convert.ToByte(Console.ReadLine());
Console.Write("Введите количество строк m: ");
short rows = short.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
short columns = short.Parse(Console.ReadLine());

int[,,] CreateArrayThree(int p, int m, int n)
{

    Random random = new Random();
    int[,,] arr = new int[p, m, n];

    //int[] arr1 = new int[]
    for (int k = 0; k < p; k++)
    {
        for (int i = 0; i < m; i++)
        {

            for (int j = 0; j < n; j++)
            {
                arr[k, i, j] = random.Next(10, 100);
                int num = random.Next(10, 100);

                for (int f = 0; f <= j; f++)
                {
                    if (num == arr[k, i, f])
                    {
                        num = random.Next(10, 100);
                        f = -1;
                    }

                }
                arr[k, i, j] = num;

            }
        }
    }
    return arr;
}

void PrintArrayThree(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        Console.WriteLine($"Page № {k+1} ");
        Console.WriteLine();
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            Console.WriteLine($"Row № {i+1} ");
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                Console.Write(arr[k, i, j] + $"[{k},{i},{j}]  ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,,] myArray = CreateArrayThree(pages, rows, columns);
PrintArrayThree(myArray);

