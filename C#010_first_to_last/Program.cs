Console.WriteLine("Enter three-digit number");
int numberA = Convert.ToInt32(Console.ReadLine()); ;
while ((numberA < 100) || (numberA > 999))
{
    Console.WriteLine("Enter three-digit number");
    numberA = Convert.ToInt32(Console.ReadLine());
}
foreach (int c in numberA)
{
    for (int i = 0; i < 3; i++)
    {
        if (i == 1)
            continue;
        Console.Write(i);
    }
}
int[] numbers = Console.ReadLine()