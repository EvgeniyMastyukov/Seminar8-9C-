// Задача 72: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления 
//нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит, 
//которые занимают числа из массива data. Напишите программу, которая составит массив десятичных
//представлений чисел массива data с учётом информации из массива info.
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

double[] binaryNumTODec = new double[info.Length];
int index = 0;
for (int i = 0; i < info.Length; i++) //4
{
    int n = info[i] - 1;
    for (int j = index; j < index + info[i]; j++) //от 0 до 2 // от 0 до 3
    {
        binaryNumTODec[i] += data[j] * Math.Pow(2, n);
        n--;
    }
    index += info[i];
}
PrintArrOneInt(binaryNumTODec);

System.Console.WriteLine();

// int[]binaryNumInt = Array.ConvertAll(binaryNum, int.Parse);

void PrintArrOne(string[] arr)
{
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write(arr[k] + "\t");
    }
}
void PrintArrOneInt(double[] arr)
{
    for (int k = 0; k < arr.Length; k++)
    {
        Console.Write(arr[k] + "\t");
    }
}