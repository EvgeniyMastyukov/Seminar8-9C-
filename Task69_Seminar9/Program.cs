//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии. A = 3; B = 5 -> 243 (3⁵)  A = 2; B = 3 -> 8 

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int numberB = int.Parse(Console.ReadLine());

int FindPowerNumber(int a, int b)
{
    return b == 0 ? 1 : FindPowerNumber(a, b - 1) * a;
}
Console.WriteLine(FindPowerNumber(numberA, numberB));