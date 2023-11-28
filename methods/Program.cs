//Чтение числа
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// генерация массива
int[] GenerateArray(int size, int leftRange, int rihtRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rihtRange);
    }
    return tempArray;
}
// печатанье массива
void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}
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
// меняет значения на противоположное
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
// замена сомволов
string Replase(string txt, char oldValue, char newValue)
{
    string result = string.Empty;
    for (int i = 0; i <= txt.Length - 1; i++)
    {
        if (txt[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{txt[i]}";
        }
    }
    return result;
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
