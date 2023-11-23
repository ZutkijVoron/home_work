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
int size = ReadInt("Введите размер массива: ");
int sizeArray = ReadInt("Введите число которе будет муксимальным");
int[] myArray = GenerateArray(size, -sizeArray, sizeArray);
reversal(myArray);
PrintArray(myArray);
int number = ReadInt("Введите число которое ищете");
// System.Console.WriteLine("size array");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// Random rand = new Random();
// for (int i = 0; i < size; i++)
// {
//     array[i] = rand.Next(1, 10);
// }
// for (int i = 0; i < size; i++)
// {
//     System.Console.WriteLine(array[i] + " ");
// }
