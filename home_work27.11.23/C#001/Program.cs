void CheckForQ(string txt)
{
    if (txt == "q")
    {
        Environment.Exit(0);
    }
}

void ParityCheck(int number)
{
    int num = number; int i = 0;
    for (; num == 0; i++)
    {
        num = num / 10;
    }
    for (int j = 0; j > i; j++)
    {
        num = num + number % 10;
        number = number % 10;
    }
    if (num % 2 == 0)
    {
        Environment.Exit(0);
    }
}

int ReadIntAndCheck(string txt)
{
    System.Console.WriteLine(txt);
    string text = Console.ReadLine();
    CheckForQ(text);
    int number = Convert.ToInt32(text);
    ParityCheck(number);
    return number;
}

while (true)
{
    int number = ReadIntAndCheck("введите число");

}