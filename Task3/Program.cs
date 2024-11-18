// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

int[] array = {1, 5, 2, 4, 6};

void PrintMatrix(int size)
{
    if (size == 0)
    {
        return;
    }
    Console.Write($"{array[size-1]}, ");
    PrintMatrix(size - 1);
}

PrintMatrix(array.Length);