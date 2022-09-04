/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


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
void StreamlineArray(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            int minPosition = j;

            for (int k = j + 1; k < tab.GetLength(1); k++)
            {
                if (tab[i, k] < tab[i, minPosition])
                    minPosition = k;
            }
            int temporary = tab[i, j];
            tab[i, j] = tab[i, minPosition];
            tab[i, minPosition] = temporary;

            Console.Write($"{tab[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] table = new int[4, 5];

FillArray(table);
PrintArray(table);
Console.WriteLine();
StreamlineArray(table);