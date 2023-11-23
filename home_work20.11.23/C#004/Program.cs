using System.Globalization;

System.Console.WriteLine("Введите число, которое больше 0");
int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
{
    System.Console.WriteLine("Введите число, которое больше 0");
    number = Convert.ToInt32(Console.ReadLine());
}
int temp = 0;
while (number > 0)
{
    temp = number % 10;
    number = number / 10;
    System.Console.Write(temp + ", ");
}