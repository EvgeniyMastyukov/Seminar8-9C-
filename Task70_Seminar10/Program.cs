// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18               6 и 10, N = 4 -> 6 10 16 26

Console.WriteLine("Задайте первое число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число b: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте длину последовательности N: ");
int numberN = int.Parse(Console.ReadLine());

void FindOrder(int a, int b, int n)
{
    if (n == 0) return;
    Console.Write($"{a} ");
    int temp = b;
    b = a + b;
    a = temp;
    FindOrder(a, b, n - 1);
}
FindOrder(numberA, numberB, numberN);


