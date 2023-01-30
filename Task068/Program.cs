// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (n > 0 && m == 0)
        return AckermannFunction(n - 1, 1);
    else
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}

Console.WriteLine($"A({n}, {m}) = {AckermannFunction(n, m)}");