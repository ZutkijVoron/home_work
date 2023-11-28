
void SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int apos = array.Length - i - 1;
        int temp = array[i];
        array[i] = array[apos];
        array[apos] = temp;
        if (i == (array.Length - 1) / 2)
        {
            break;
        }
    }
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

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}

int size = ReadInt("Введите размер массива");

int leftRange = ReadInt("Введите минимальное значение");

int rihtRange = ReadInt("Введите максимальное число");

int[] ar = GenerateArray(size, leftRange, rihtRange);

PrintArray(ar);

SortedArray(ar);

PrintArray(ar);