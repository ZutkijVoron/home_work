// пишет да или нет на каждое число
void FindNumber(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == N)
        {
            System.Console.WriteLine("Да");
            return;
        }
        System.Console.WriteLine("Нет");
    }
}
// меняет значения на противоположное(-/+)
void reversal(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}
// умножение элементов которые лежат зеркально
int[] Multiplying(int[] array)
{
    int[] multiplyingArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
        multiplyingArray[i] = array[i] * array[array.Length - i - 1];
    }
    return multiplyingArray;
}
// сортировка массива
void SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minpos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minpos])
            {
                minpos = j;
            }
        }
        int temp = array[i];
        array[i] = array[minpos];
        array[minpos] = temp;
    }
}
// счёт чисел подходящих под условие (на какое делятся и на какое кончается)
int Counter(int[] array, int div, int end)
{
    int i = 0;
    foreach (int number in array)
    {
        if ((number % div == 0) && (number % 10 == end))
        {
            i++;
        }
    }
    return i;

}
// создаёт целое число из массива(с учётом разрядности)
int PrintNumArr(int[] array)
{
    int result = 0;
    int mult = (int)Math.Pow(10, array.Length - 1);
    foreach (int number in array)
    {
        result += number * mult;
        mult /= 10;
    }
    return result;
}
// проверяет является ли число простым
bool IsPrime(int number)
{
    if (number < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}
// выводит и пишет общее количество простых чисел
int CountPrimes(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (IsPrime(number))
        {
            Console.Write(number + " ");
            count++;
        }
    }
    return count;
}
// поиск факториала
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
// поиск числа фибоначи
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
// нахождение среднего числа в строках
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
// сумма чисел двух мерного массава, которые находятся по диагонали
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


