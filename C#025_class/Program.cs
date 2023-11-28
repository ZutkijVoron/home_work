using System.ComponentModel.DataAnnotations;

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

int count = ReadInt("Введите размер массива: ");


int[] array = GenerateArray(count, 0, 9);

PrintArray(array);

System.Console.WriteLine(PrintNumArr(array));