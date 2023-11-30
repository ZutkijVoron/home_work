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
double[] FindAverageInRows(int[,] matrix)
{
    double[] averageArray = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            averageArray[i] += matrix[i, j];
        }
        averageArray[i] = Math.Round(averageArray[i] / matrix.GetLength(1), 3);
    }

    return averageArray;
}
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
void PrintArray(double[] array)
{
    Console.WriteLine("[ " + string.Join(" | ", array) + " ]");
}
int SummLine(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    System.Console.WriteLine(sum);
    return sum;
}


int rows = ReadInt("Введите кол-во строк");
int columns = ReadInt("Введите кол-во колонок");
int[,] matrix = CreateandFill2DIntArray(rows, columns, 1, 10);
Print2DIntArray(matrix);

PrintMatrix(matrix);

double[] averageArray = FindAverageInRows(matrix);

PrintArray(averageArray);