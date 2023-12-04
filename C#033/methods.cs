using static System.Console;

public static class MyMethods
{
    /// <summary>
    /// Считывание числа из консоли
    /// </summary>
    /// <param name="text">текст выводящийся перед запросом числа</param>
    /// <returns>число</returns>
    public static int ReadInt(string text = "Enter number")
    {
        WriteLine(text);
        return int.Parse(ReadLine()!);
    }
    /// <summary>
    /// Считывание числа из консоли
    /// </summary>
    /// <param name="text">текст выводящийся перед запросом числа</param>
    /// <returns>число</returns>
    public static double ReadDouble(string text = "Enter number")
    {
        WriteLine(text);
        return double.Parse(ReadLine()!);
    }
    /// <summary>
    /// создание двухмерного массива
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <param name="minnumber">наименьшее число массива</param>
    /// <param name="maxnumber">наибольшее число массива</param>
    /// <returns>массив</returns>
    public static int[] GenerateArray(int size, int minnumber = 0, int maxnumber = 10)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            tempArray[i] = rand.Next(minnumber, maxnumber);
        }
        return tempArray;
    }
    /// <summary>
    /// создание двухмерного массива
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <param name="minnumber">наименьшее число массива</param>
    /// <param name="maxnumber">наибольшее число массива</param>
    /// <returns>массив</returns>
    public static double[] GenerateArray(int size, double minnumber = 0.0, double maxnumber = 10.0)
    {
        double[] tempArray = new double[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            tempArray[i] = rand.NextDouble() * (maxnumber - minnumber) + minnumber;
        }
        return tempArray;
    }
    /// <summary>
    /// печатанье массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="str">разделитель между числами массива</param>
    public static void PrintArray(int[] array, string str = ", ")
    {
        string output = string.Join(str, array);
        WriteLine($"[{output}]");
    }
    /// <summary>
    /// печатанье массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="str">разделитель между числами массива</param>
    public static void PrintArray(double[] array, string str = ", ")
    {
        string output = string.Join(str, array);
        WriteLine($"[{output}]");
    }
    /// <summary>
    /// замена символов в строке
    /// </summary>
    /// <param name="txt">текст в котором нужно изменить символы</param>
    /// <param name="oldValue">символ, который нужно заменить</param>
    /// <param name="newValue">символ, на который нужно заменить</param>
    /// <returns>возвращает результат замены</returns>
    public static string Replase(string txt, char oldValue, char newValue)
    {
        string result = string.Empty;
        for (int i = 0; i <= txt.Length - 1; i++)
        {
            if (txt[i] == oldValue)
            {
                result = result + $"{newValue}";
            }
            else
            {
                result = result + $"{txt[i]}";
            }
        }
        return result;
    }
    /// <summary>
    /// сортировка массива выбором
    /// </summary>
    /// <param name="array">массив</param>
    public static void SelectionSortedArray(int[] array)
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
    /// <summary>
    /// сортировка массива выбором
    /// </summary>
    /// <param name="array">массив</param>
    public static void SelectionSortedArray(double[] array)
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
            double temp = array[i];
            array[i] = array[minpos];
            array[minpos] = temp;
        }
    }
}