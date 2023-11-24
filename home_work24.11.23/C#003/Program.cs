using System.ComponentModel.DataAnnotations;

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[] GeerateDoubleArray(int size)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.NextDouble();
    }

    return tempArray;
}
void PrintDoubleArray(double[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "]");
    System.Console.WriteLine();
}
double MinMaxInDoubleArray(double[] array, int size)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        else if (max < array[i])
        {
            max = array[i];
        }
    }
    double minandmax = max - min;
    return minandmax;
}

int size = ReadInt("Введите размер массива: ");

double[] newarray = GeerateDoubleArray(size);

PrintDoubleArray(newarray);

System.Console.WriteLine(MinMaxInDoubleArray(newarray, size));
