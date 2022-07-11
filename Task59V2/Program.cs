// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку
//и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] CreateMatrix(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(100);
        }
    }
    return arr;
}
void PrintMatrix(int[,] prarr)
{
    for (int i = 0; i < prarr.GetLength(0); i++)
    {
        for (int j = 0; j < prarr.GetLength(1); j++)
        {
            Console.Write(prarr[i, j] + "\t"); //  "\t" - горизонтальная табуляция
        }
        System.Console.WriteLine();
    }
}

int GetMinValueMatrix(int[,] matrix, out int indexI, out int indexJ) // out нужен для возврата этих переменных наряду с основным обохначенным return.
{
    indexI = 0;
    indexJ = 0;
    int min = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < min)
            {
                min = matrix[i,j];
                indexI = i;
                indexJ = j;
            }            
        }    
    }
    return min;
}

int [,] CutLeastElementCross(int[,] matrix)
{
    if(matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
    {
        int[,] emptyMatrix = {{0}};
        return emptyMatrix;
    }
    int min = GetMinValueMatrix(matrix, out var indexI, out var indexJ);
    Console.Write($"Миним. значение массива = {min}\n Ряд - {indexI +1}, столбец - {indexJ +1} ");
    System.Console.WriteLine(); // "\n" - новая стока.

    int[,] resultMatrix = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int flagI;
            int flagJ;
            if(i >= indexI ) flagI = 1;
            else flagI = 0;
            if(j >= indexJ) flagJ = 1;
            else flagJ = 0;
            resultMatrix[i,j] = matrix[i + flagI, j + flagJ];
        }        
    }
    return resultMatrix;
}

var matrix1 = CreateMatrix(4,4);
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = CutLeastElementCross(matrix1);
PrintMatrix(matrix2); 