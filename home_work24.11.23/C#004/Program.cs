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

int number = ReadInt("Введите число от 1 до 100.000");
while (number < 1 || number > 100000)
{
    number = ReadInt("Введите число от 1 до 100.000");
}

int size = 0;
int numbertemp = number;

while (numbertemp != 0)
{
    numbertemp = numbertemp / 10;
    size++;
}

int[] array = new int[size];
int i = 0;

while (number != 0)
{
    array[size - 1 - i] = number % 10;
    number = number / 10;
    i++;
}

PrintArray(array);