// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12  45 -> 9

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int FindSumDigital(int num)
{
    if(num/10 == 0) return num;
    else return num%10 + FindSumDigital(num/10);
}

int res = FindSumDigital(number);
System.Console.WriteLine($"summa digital = {res}");