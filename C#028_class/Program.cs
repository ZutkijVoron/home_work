int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
void Print2DIntArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            System.Console.Write($"{array[rows, columns]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] CreateandFill2DIntArray(int rows, int columns, int leftRange, int rihtRange)
{
    int[,] tempmatrix = new int[rows, columns];
    Random rand = new Random();
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        System.Console.WriteLine();
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = rand.Next(leftRange, rihtRange);
        }
    }
    return tempmatrix;
}
void ChangeMatrix()


int rows = ReadInt("Введите кол-во строк");
int columns = ReadInt("Введите кол-во колонок");
int[,] matrix = Create2DArray(rows, columns);
CreateandFill2DIntArray(matrix, 1, 10);
Print2DIntArray(matrix);
System.Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i += 2)
{
    for (int j = 0; j < matrix.GetLength(1); j += 2)
    {
        matrix[i, j] = (int)Math.Pow(matrix[i, j], 2);
    }
}
Print2DIntArray(matrix);