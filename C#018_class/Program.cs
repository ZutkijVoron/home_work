System.Console.WriteLine("введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 * number1 == number2)
{
    System.Console.WriteLine($"{number2} -> квадрат {number1}");
}
else if (number2 * number2 == number1)
{
    System.Console.WriteLine($"{number1} -> квадрат {number2}");
}
else
{
    System.Console.WriteLine($"НИ один из них не является квадратом");
}