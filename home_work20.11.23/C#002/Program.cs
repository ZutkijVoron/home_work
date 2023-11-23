using System.Globalization;

System.Console.WriteLine("введите x");
int X = Convert.ToInt32(Console.ReadLine());
while (X == 0)
{
    System.Console.WriteLine("введите x");
    X = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine("введите y");
int Y = Convert.ToInt32(Console.ReadLine());
while (Y == 0)
{
    System.Console.WriteLine("введите y");
    Y = Convert.ToInt32(Console.ReadLine());
}
if (X > 0 && Y > 0)
{
    System.Console.WriteLine("Первая четверть");
}
else if (Y > 0 && X < 0)
{
    System.Console.WriteLine("Вторая четверть");
}
else if (Y < 0 && X < 0)
{
    System.Console.WriteLine("Третья четверть");
}
else
{
    System.Console.WriteLine("Четвёртая четверь");
}