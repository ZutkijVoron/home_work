using static MyMethods;
using static System.Console;


void PrintReverseArray(int[] array, int i = 0, int count = 1)
{
    i = array.Length - count;
    if (i < 0)
    {
        return;
    }
    Write(array[i] + " ");
    count++;
    PrintReverseArray(array: array, count: count);
}




int[] array = GenerateArray(10, 0, 10);
PrintArray(array);
PrintReverseArray(array);