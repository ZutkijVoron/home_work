using System.Security.Cryptography.X509Certificates;
using static MyMethods;
using static System.Console;



string str = "";
int num = ReadInt("Enter number of letters");

for (int i = 0; i < num; i++)
{
    str = str + ReadLine();
}
WriteLine(str.ToLowerInvariant());