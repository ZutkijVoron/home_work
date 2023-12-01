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
// вывод массива
void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}
// поиск строки с минимальной суммой 
int[] RowMinSum(int[,] matrix)
{
    int sum = 0;
    int minsum = 0;
    int[] min = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum || i == 0)
        {
            int b = 0;
            minsum = sum;
            for (; b < matrix.GetLength(1); b++)
            {
                min[b] = matrix[i, b];
            }

        }
        sum = 0;
    }
    return min;
}



int rows = ReadInt("введите кол-во строк");
int columns = ReadInt("введите кол-во колонок");
int leftRange = ReadInt("введите число которое будет минимальным");
int rihtRange = ReadInt("введите число которое будет максимальным");

int[,] ar = CreateandFill2DIntArray(rows, columns, leftRange, rihtRange);
Print2DIntArray(ar);
int[] minrowsum = RowMinSum(ar);
PrintArray(minrowsum);