int ReadInt(string txt)
{
    System.Console.WriteLine(txt);
    return Convert.ToInt32(Console.ReadLine());
}

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

void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}

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

int numarray = ReadInt("введите размер массива");

int leftRange = ReadInt("введите начальное значение");

int rihtRange = ReadInt("введите максимальное значение");

int[] array = GenerateArray(numarray, leftRange, rihtRange);

PrintArray(array);

int div = ReadInt("делится на ");

int end = ReadInt("кончается на ");

int count = Counter(array: array, div: div, end: end);

System.Console.WriteLine($"количество чисел которые делятся на {div} и кончаются на {end}: {count}");