//Задача 62: Заполните спирально массив 4 на 4.
//1  2  3  4
//12 13 14 5
//11 16 15 6
//10  9  8 7

// Console.Write("Введите количество строк m: ");
// byte rows = Convert.ToByte(Console.ReadLine());
// Console.Write("Введите количество столбцов n: ");
// byte columns = Convert.ToByte(Console.ReadLine());

int[,] CreateArraay(int m, int n)
{
    Random random = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = 0;
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

//int[,] myArray = CreateArraay(rows, columns);
System.Console.WriteLine();
//PrintArray(myArray);


int[] arr1 = new int[16];
int col = 1;
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = col;
    col++;
}

void PrintOneArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
}

System.Console.WriteLine();
PrintOneArray(arr1);

int[,] myArray = new int [,]
{
{1,1,1,1,1,1},
{1,0,0,0,0,1},
{1,0,0,0,0,1},
{1,0,0,0,0,1},
{1,0,0,0,0,1},
{1,1,1,1,1,1},
};

void FillSpiral(int m, int n)
{
    //m = 0; n = 0;
    int num = 1;

    if (myArray[m, n] == 0)
    {
        myArray[m, n] = num;
        num++;
    }

    FillSpiral(m, n + 1);
    FillSpiral(m + 1, n);
    FillSpiral(m, n - 1);
    FillSpiral(m - 1, n);

}
FillSpiral(1, 1);
System.Console.WriteLine();
PrintArray(myArray);

