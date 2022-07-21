// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке 
//от M до N. Выполнить с помощью рекурсии. M = 1; N = 15 -> 120   M = 4; N = 8. -> 30

Console.Write("Задайте  число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Задайте  число N: ");
int numN = int.Parse(Console.ReadLine());

int FindSumOfRange1(int m, int n) // m < n
{
    if(m == n) return m;
    else return n + FindSumOfRange1(m,n-1);
}

int FindSumOfRange2(int m, int n) // m > n
{
    if(m == n) return m;
    else return m + FindSumOfRange2(m-1,n);
}
if(numM <= numN) Console.WriteLine($"Summa = {FindSumOfRange1(numM, numN)}"); 
if(numM > numN) Console.WriteLine($"Summa = {FindSumOfRange2(numM, numN)}"); 


