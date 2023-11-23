using System.Globalization;

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine("не кратно");
}