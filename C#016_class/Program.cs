int number = new Random().Next(100, 1000);
int number1 = number / 100;
int number2 = number % 10;
System.Console.WriteLine($"{number} -> {number1}{number2}");