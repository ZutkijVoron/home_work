/*
0. константные
1. логорифмические
2. линейно-логорифмические
3. линейные
4. квадратные
5. кубические
*/
Console.Clear();
System.Console.WriteLine("enter number");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine($"summ = {(1 + n) / 2 * n}");
поиск числа
Console.Clear();
System.Console.WriteLine("Загадайте число от одного до тысячи");
int leftnum = 1;
int rightnum = 1000;
int temp = 0;
string str = "";
for (; leftnum < rightnum;)
{
    if (str.ToLower() == "")
    {

    }
    else if (temp == (leftnum + rightnum) / 2)
    {
        break;
    }

    else if (str.ToLower() == "y")
    {
        leftnum = (leftnum + rightnum) / 2;
    }
    else if (str.ToLower() == "n")
    {
        rightnum = (leftnum + rightnum) / 2;
    }
    else
    {
        System.Console.WriteLine($"напишите пожалуйста либо y, либо n");

    }
    temp = leftnum;
    System.Console.WriteLine($"это число больше или равно {(leftnum + rightnum) / 2}??????");
    str = Console.ReadLine();
}
System.Console.WriteLine($"число которое вы загадали -> {leftnum}");