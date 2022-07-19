//Задача 62: Заполните спирально массив 4 на 4.
//1  2  3  4
//12 13 14 5
//11 16 15 6
//10  9  8 7

int[,] array = new int[4, 4];
int num = 1;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j <= array.GetLength(1); j++)
    {
        if (j < array.GetLength(1))
        {
            array[i, j] = num;
            num++;
        }
        else
        {
            int k = 0;
            int r = 0;

            for (k = i + 1; k < array.GetLength(0); k++) //5,6,7
            {
                array[k, j - 1] = num;
                num++;
            }

            for (r = j - 2; r >= 0; r--)   //8,9,10
            {
                array[k - 1, r] = num;
                num++;
            }

            r = r + 1;
            for (k = k - 2; k >= 1; k--) //11,12
            {
                array[k, r] = num;
                num++;
            }
            k = k + 1;
            for (r = r + 1; r < array.GetLength(1) - 1; r++)
            {
                array[k, r] = num;
                num++;
            }
            System.Console.WriteLine($"k = {k}");
            System.Console.WriteLine($" r = {r}");
            k += 1;
            for (r = r - 1; r > 0; r--)
            {
                array[k, r] = num;
                num++;
            }
        }

    }
    break;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
System.Console.WriteLine();
PrintArray(array);
