//1 method
void Method1()
{
    System.Console.WriteLine("proba");
}

// Method1();

// 2 method
void Method2(string arg)
{
    System.Console.WriteLine(arg);
}

// Method2("plak-plak");

void Method21(string arg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(arg);
        i++;
    }
}

// Method21("plak-plak", 10);

// Method21(count: 10, arg: "plak-plak");

// 3 method

int Method3()
{
    return DateTime.Now.Month;
}

// int mounth = Method3();
// System.Console.WriteLine(mounth);

// 4 method

string Method4(int count, string tex)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + tex;
    }
    return result;
}

// string res = Method4(tex: "plak-plak ", count: 5);
// System.Console.WriteLine(res);
string Replase(string txt, char oldValue, char newValue)
{
    string result = string.Empty;
    for (int i = 0; i <= txt.Length - 1; i++)
    {
        if (txt[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{txt[i]}";
        }
    }
    return result;
}
System.Console.Write("Введите текст: ");
string? text = Console.ReadLine();
System.Console.WriteLine("Изменить текст? y/n");
string i = Console.ReadLine();
if (i == "y")
{
    System.Console.Write("Какой символ необходимо сменить? ");
    char oldValue = Convert.ToChar(Console.ReadLine());

    System.Console.Write("На какой символ необходимо сменить? ");
    char newValue = Convert.ToChar(Console.ReadLine());

    string res = Replase(text, oldValue, newValue);
    System.Console.WriteLine(res);
    for (System.Console.WriteLine("Продолжать изменить текст? y/n"), i = Console.ReadLine(); i == "y";)
    {
        System.Console.Write("Какой символ необходимо сменить? ");
        oldValue = Convert.ToChar(Console.ReadLine());

        System.Console.Write("На какой символ необходимо сменить? ");
        newValue = Convert.ToChar(Console.ReadLine());

        res = Replase(res, oldValue, newValue);

        System.Console.WriteLine(res);
        System.Console.WriteLine("Продолжать изменить текст? y/n");
        i = Console.ReadLine();
    }
    System.Console.WriteLine($"Конечный результат: {res}");
}

