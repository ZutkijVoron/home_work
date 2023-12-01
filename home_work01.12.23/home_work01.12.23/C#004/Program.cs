// Чтение числа
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
// поиск минимума
int SearchMinPosI(int[,] matrix)
{
    int min = matrix[0, 0];
    int minposi = 0;
    int minposj = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                minposi = i;
                minposj = j;
            }
        }
    }
    return minposi;
}
int SearchMinPosJ(int[,] matrix)
{
    int min = matrix[0, 0];
    int minposi = 0;
    int minposj = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                minposi = i;
                minposj = j;
            }
        }
    }
    return minposj;
}
// удаление строчек с минимальным значением
int[,] DeletRows(int[,] matrix)
{
    int r = 0;
    int k = 0;
    int[,] tempmat = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != SearchMinPosI(matrix) && j != SearchMinPosJ(matrix))
            {
                if (r < tempmat.GetLength(0) && k < tempmat.GetLength(1))
                {
                    tempmat[r, k] = matrix[i, j];
                    r++;
                    k++;
                }
            }
            else
            {

            }
        }
    }
    return tempmat;
}



int rows = ReadInt("введите кол-во строк");
int columns = ReadInt("введите кол-во колонок");
int leftRange = ReadInt("введите число которое будет минимальным");
int rihtRange = ReadInt("введите число которое будет максимальным");

int[,] ar = CreateandFill2DIntArray(rows, columns, leftRange, rihtRange);
Print2DIntArray(ar);
int[,] newar = DeletRows(ar);
Print2DIntArray(newar);