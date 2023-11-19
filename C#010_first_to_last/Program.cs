Console.WriteLine("Enter three-digit number");
int numberA = Convert.ToInt32(Console.ReadLine());
while (99 >= numberA || numberA >= 1000)
{
    Console.WriteLine("Enter three-digit number");
    numberA = Convert.ToInt32(Console.ReadLine());
}
int firstnumber = numberA / 100;
int thirdnumber = numberA % 10;
int sum = firstnumber + thirdnumber;
System.Console.WriteLine(sum);