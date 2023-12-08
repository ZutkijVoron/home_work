using static MyMethods;
using static System.Console;


void PrintReverseArray(int[] array, int i = 0)
{
    if (i == array.Length)
    {
        return;
    }

    PrintReverseArray(array, i + 1);
    Write(array[i] + " ");
}




int[] array = GenerateArray(10, 0, 10);
PrintArray(array);
PrintReverseArray(array);