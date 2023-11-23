using System.Globalization;

System.Console.WriteLine("Введите число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10 || number > 99)
{
    System.Console.WriteLine("Введите число от 10 до 99");
    number = Convert.ToInt32(Console.ReadLine());
}
int div = number / 10;
int ost = number % 10;
if (div > ost)
{
    System.Console.WriteLine($"{div} > {ost}");
}
else if (ost > div)
{
    System.Console.WriteLine($"{ost} > {div}");
}
else
{
    System.Console.WriteLine($"{ost} = {div}");
}