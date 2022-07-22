// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Задайте  число m: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Задайте  число n: ");
int numN = int.Parse(Console.ReadLine());

int Akkerman(int m, int n )
{
    if(m == 0) return n + 1;
    else if ((n == 0) && (m!=0)) return Akkerman(m-1,1);
    else return Akkerman(m-1, Akkerman(m,n-1)); 

}
int res = Akkerman(numM, numN);
System.Console.WriteLine($"Функция Аккермана = {res}");