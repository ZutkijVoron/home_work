using System.Reflection.Metadata.Ecma335;

int ReadInt(string text)
{
    System.Console.WriteLine(text);
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

void reversal(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] multiplying(int[] array)
{
    int[] multiplyingArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {

        multiplyingArray[i] = array[i] * array[array.Length - i - 1];
    }
    return multiplyingArray;
}

int size = ReadInt("Введите размер массива: ");

int sizeArray = ReadInt("Введите число которе будет максимальным");

int[] myArray = GenerateArray(size, -sizeArray, sizeArray);

PrintArray(myArray);
PrintArray(multiplying(myArray));

int number = ReadInt("Введите число которое ищете");

FindNumber(myArray, number);
FindNumber(multiplying(myArray), number);