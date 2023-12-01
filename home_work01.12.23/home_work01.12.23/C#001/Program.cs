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
// поиск числа в матрице по строке и колонке
void SearchIntIn2DArray(int[,] array, int row, int column)
{
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        System.Console.WriteLine("данного числа нет в массиве");
    }
    else
    {
        System.Console.WriteLine(array[row, column]);
    }
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


int rows = ReadInt("введите кол-во строк");
int columns = ReadInt("введите кол-во колонок");
int leftRange = ReadInt("введите число которое будет минимальным");
int rihtRange = ReadInt("введите число которое будет максимальным");

int[,] ar = CreateandFill2DIntArray(rows, columns, leftRange, rihtRange);
Print2DIntArray(ar);
int line = ReadInt("введите номер строки элемента который ищите");
int pillar = ReadInt("введите номер колонки элемента который ищите");
SearchIntIn2DArray(ar, line, pillar);