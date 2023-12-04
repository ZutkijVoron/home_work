void SortVibor(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int indexMin = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indexMin])
            {
                indexMin = j;
            }
        }
        if (array[indexMin] == array[i])
        {
            continue;
        }
        int temp = array[i];
        array[i] = array[indexMin];
        array[indexMin] = temp;
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
    return int.Parse(Console.ReadLine()!);
}
void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}





int size = ReadInt("Введите число элементов в массиве");
int[] array = GenerateArray(size, -10, 11);
PrintArray(array);
SortVibor(array);
PrintArray(array);