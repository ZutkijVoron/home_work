using static MyMethods;
using static System.Console;


string str = "";
int num = ReadInt("Enter number of letters");

for (int i = 0; i < num; i++)
{
    str = str + ReadLine();
}
string yesorno = "";
for (int i = 0; i < str.Length; i++)
{
    if (str[i] == str[str.Length - i - 1])
    {
        yesorno = "yes";
    }
    else
    {
        yesorno = "no";
        break;
    }
}
WriteLine(yesorno);