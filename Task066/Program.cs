// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

int NaturalNumbersSum(int n, int m)
{
    if (n == m)
        return m;
    return m + NaturalNumbersSum(n, m - 1);
}

Console.WriteLine($"Сумма элементов от {n} до {m} = {NaturalNumbersSum(n, m)}");