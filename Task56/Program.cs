/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

void FillArray(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {

            tab[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write($"{tab[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MinSumLineArray(int[,] tab)
{
    int sum = 0;
    int line = 0;
    int minsum = 100;
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            sum = sum + tab[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            line = i + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов в {line} строке = {minsum}");
}


int[,] table = new int[4, 5];

FillArray(table);
PrintArray(table);
Console.WriteLine();
MinSumLineArray(table);