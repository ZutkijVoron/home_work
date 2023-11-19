System.Console.WriteLine("enter number");
int numberA = Convert.ToInt32(Console.Read());
do
{
    Console.WriteLine("Enter three-digit number");
    numberA = Convert.ToInt32(Console.Read());
}
while ((numberA > 100) && (numberA < 999));
System.Console.WriteLine("eee");