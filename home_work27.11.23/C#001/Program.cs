void CheckForQ(string txt)
{
    if (txt == "q")
    {
        Environment.Exit(0);
    }
}

void ParityCheck(int number)
{
    if (number % 2 == 0)
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