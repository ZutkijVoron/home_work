﻿// Чтение числа
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// создание и заполнение матрицы
int[,] CreateandFill2DIntArray(int rows, int columns, int leftRange, int rihtRange)
{
    int[,] tempmatrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < tempmatrix.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < tempmatrix.GetLength(1); j++)
        {
            tempmatrix[i, j] = rand.Next(leftRange, rihtRange);
        }
    }
    return tempmatrix;
}
// вывод матрицы
void Print2DIntArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            System.Console.Write($"{array[rows, columns]} ");
        }
        System.Console.WriteLine();
    }
}
// поменять местами 1 и последнию строки
void SubstitutionIn2DArray(int[,] mateix)
{
    int temp = 0;
    for (int i = 0; i < mateix.GetLength(0); i++)
    {
        for (int j = 0; j < mateix.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = mateix[i, j];
                mateix[i, j] = mateix[(mateix.GetLength(0) - 1), j];
                mateix[(mateix.GetLength(0) - 1), j] = temp;
            }
        }
    }
}




int rows = ReadInt("введите кол-во строк");
int columns = ReadInt("введите кол-во колонок");
int leftRange = ReadInt("введите число которое будет минимальным");
int rihtRange = ReadInt("введите число которое будет максимальным");

int[,] ar = CreateandFill2DIntArray(rows, columns, leftRange, rihtRange);
Print2DIntArray(ar);
SubstitutionIn2DArray(ar);
Print2DIntArray(ar);