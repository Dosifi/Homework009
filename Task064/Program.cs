// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите натуральное значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int k = 0;
if (n <= k)
{
    Console.WriteLine("Ввели не положительное число");
}

int NaturalNumbers(int n, int k)
{
    if (n == k)
        return n;
    else
        Console.Write($"{NaturalNumbers(n, k + 1)} ");
    return k;
}

NaturalNumbers(n, k);