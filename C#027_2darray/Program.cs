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

void Fill2DIntArray(int[,] array, int leftRange, int rihtRange)
{
    Random rand = new Random();
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        System.Console.WriteLine();
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            array[rows, columns] = rand.Next(leftRange, rihtRange);
        }
    }
}

double Factorial(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

double Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
for (int i = 1; i < 40; i++)
{

    System.Console.WriteLine(Fibonacci(i));
}