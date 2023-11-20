System.Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());
int ost = number1 % number2;
if (ost == 0)
{
    System.Console.WriteLine($"{number1}, {number2} -> multiple");
}
else
{
    System.Console.WriteLine($"{number1}, {number2} -> not a multiple, remainder {ost}");
}