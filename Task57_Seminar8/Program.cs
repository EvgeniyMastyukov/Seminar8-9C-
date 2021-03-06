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
int[,] array = GetArray(rows, columns);
PrintArray(array);

void PrintOneArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t ");
    }
}

int[] GetFrequencyList(int[,] arr)
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

    return oneArr1;
}

int[] resaltArr = GetFrequencyList(array);
System.Console.WriteLine();
PrintOneArr(resaltArr);

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

int count = 0;
for (int i = 0; i < resaltArr.Length - 1; i++)
{
    for (int j = i + 1; j < resaltArr.Length; j++)
    {
        if (resaltArr[i] == resaltArr[j])
        {
            count++;
            i++;
        }
    }
}
int sumUnik = resaltArr.Length - count;
Console.WriteLine($"sumUnik = {sumUnik} count = {count}");

int[] voc = new int[sumUnik];
voc[0] = resaltArr[0];
int flag = 1;
for (int i = 1; i < voc.Length; i++)
{
    for (int j = flag; j < resaltArr.Length; j++)
    {
        if (resaltArr[j] != voc[i - 1])
        {
            voc[i] = resaltArr[j];
            flag = j;
            break;
        }
    }
}

string[,] voc1 = new string[sumUnik, 2];
int s = 0;
for (int i = 0; i < voc1.GetLength(0); i++)
{
    voc1[i, s] = $"{voc[i]}";
    System.Console.WriteLine();

}
int col = 0;
for (int i = 0; i < voc.Length; i++)
{
    col = 0;
    for (int j = 0; j < resaltArr.Length; j++)
    {
        if (voc[i] == resaltArr[j])
            col++;
    }
    voc1[i, 1] = $"встречается {col} раз";
}

PrintOneArr(voc);
System.Console.WriteLine();
void PrintStringArray(string[,] arr)
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
PrintStringArray(voc1);

















