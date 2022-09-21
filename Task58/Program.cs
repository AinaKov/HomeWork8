/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */
int[,] table1 = new int[2, 2];
    int[,] table2 = new int[2, 2];
    int[,] tableresult = new int[2, 2];

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
void NewArray(int[,] table1, int[,] table2, int[,] tableresult)
{
    for (int i = 0; i < tableresult.GetLength(0); i++)
    {
        for (int j = 0; j < tableresult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < table1.GetLength(1); k++)
            {
                sum += table1[i, k] * table2[k, j];
            }
            tableresult[i, j] = sum;
        }
    }
}
    FillArray(table1);
    PrintArray(table1);
    Console.WriteLine();

    FillArray(table2);
    PrintArray(table2);
    Console.WriteLine();

    NewArray(table1, table2, tableresult);
    PrintArray(tableresult);