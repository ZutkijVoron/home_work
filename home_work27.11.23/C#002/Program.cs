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
int Counter(int[] array, int div)
{
    int i = 0;
    foreach (int number in array)
    {
        if (number % div == 0)
        {
            i++;
        }
    }
    return i;

}
void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}

int size = ReadInt("Введите размер массива");
int[] array = GenerateArray(size, 100, 999);
PrintArray(array);
System.Console.WriteLine(Counter(array, 2));