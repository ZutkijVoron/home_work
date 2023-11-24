int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GeerateArray(int size, int leftRange, int rihtRange)
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
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int size = ReadInt("Введите размер массива: ");

int minsizearray = ReadInt("Введите число, которе будет минимальным");

int maxsizearray = ReadInt("Введите число, которе будет максимальным");

int[] newarray = GeerateArray(size, minsizearray, maxsizearray);

PrintArray(newarray);

System.Console.WriteLine(EvenNumbers(newarray));