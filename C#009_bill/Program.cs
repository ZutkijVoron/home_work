Console.WriteLine("numder");
double numberA = Convert.ToInt32(Console.ReadLine());
double index = numberA;
int count = 0;
numberA = -numberA;
while (count <= (index * 2))
{
    Console.WriteLine(numberA);
    numberA++;
    count++;
}