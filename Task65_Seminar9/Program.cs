// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"  M = 4; N = 8 -> "4, 6, 7, 8" 

Console.Write("Задайте значение М: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Задайте значение N: ");
int numberN = int.Parse(Console.ReadLine());

void NumbersRec1(int m, int n)
{
    if (n < m) return;
    NumbersRec1(m, n - 1);
    Console.Write(n + "\t");
}

void NumbersRec2(int m, int n)
{
    if (n > m) return;    
    Console.Write(m + "\t");
    NumbersRec2(m-1, n);
}



if(numberM <= numberN) NumbersRec1(numberM, numberN);
else NumbersRec2(numberM, numberN);





// string TwoNumbersRec(int m, int n)
// {
//     if(m <= n) return $"{m}" + "  " + TwoNumbersRec(m +1, n);
//     else  return String.Empty;        
// }

// string result = TwoNumbersRec(numberM, numberN);
// System.Console.WriteLine(result);