// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

int M = 2, N = 0;

int Ackermann(int m, int n)
{
    if (m == 0)
    {
       return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return 0;
}

int result = Ackermann(M, N);
Console.Write($"A({M}, {N}) = {result}");