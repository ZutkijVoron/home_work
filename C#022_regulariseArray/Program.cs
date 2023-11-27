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

int count = ReadInt("Введите размер массива: ");
int[] array = new int[count];

System.Console.WriteLine("Вводите по одному числу на строку");
for (int i = 0; i < count; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(array);

SortedArray(array);

PrintArray(array);