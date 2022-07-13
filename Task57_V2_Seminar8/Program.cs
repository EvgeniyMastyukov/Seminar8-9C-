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
            arr[i, j] = rnd.Next(9);
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
        Console.WriteLine();
    }
}
// int[,] array = GetArray(rows, columns);
// PrintArray(array);

void PrintOneArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t ");
    }
}

string[,] GetFrequencyList(int[,] arr)
{
    int[] oneArr = new int[arr.GetLength(0) * arr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            oneArr[k] = arr[i, j];
            k++;
        }
    }
    Console.WriteLine();
    PrintOneArr(oneArr);
    int[] oneArr1 = GetSort(oneArr);
    Console.WriteLine();
    PrintOneArr(oneArr1);
    int numOfUnik = FindNumberUnikElements(oneArr1);  
    System.Console.WriteLine();  
    int[] oneArr2 = IdentifyUnikElem(oneArr1);
    System.Console.WriteLine();
    System.Console.WriteLine();
    string[,] voc = Vocabulary(oneArr2,oneArr1);

    return voc;
}

int[] GetSort(int[] arr)
{
    int size = arr.Length;
    while (size > 1)
    {
        int imax = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[imax] < arr[i])
            {
                imax = i;
            }
        }
        int temp = arr[imax];
        arr[imax] = arr[size - 1];
        arr[size - 1] = temp;
        size--;
    }
    return arr;
}

int FindNumberUnikElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
                i++;
            }
        }
    }
    int sumUnik = arr.Length - count;

    Console.WriteLine($"sumUnik = {sumUnik} count = {count}");
    return sumUnik;

}

int[] IdentifyUnikElem(int[] arr)
{
    int[] voc = new int[FindNumberUnikElements(arr)];
    voc[0] = arr[0];
    int flag = 1;
    for (int i = 1; i < voc.Length; i++)
    {
        for (int j = flag; j < arr.Length; j++)
        {
            if (arr[j] != voc[i - 1])
            {
                voc[i] = arr[j];
                flag = j;
                break;
            }
        }
    }
    PrintOneArr(voc);
    return voc;
}

string[,] Vocabulary(int[] unik, int[] sort)
{
    string[,] voc1 = new string[unik.Length, 2];
    int s = 0;
    for (int i = 0; i < voc1.GetLength(0); i++)
    {
        voc1[i, s] = $"{unik[i]}";
        
    }
    int col = 0;
    s = 1;
    for (int i = 0; i < unik.Length; i++)
    {
        col = 0;
        for (int j = 0; j < sort.Length; j++)
        {
            if (unik[i] == sort[j])
                col++;
        }
        voc1[i, s] = $"встречается {col} раз";
    }
    return voc1;
}


void PrintStringArray(string[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(rows, columns);
PrintArray(array);

string[,] resalt = GetFrequencyList(array);

PrintStringArray(resalt);



















