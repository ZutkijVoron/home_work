using static MyMethods;
using static System.Console;





int rows = ReadInt("Enter rows");
int columns = ReadInt("Enter columns");
char[,] chars = new char[rows, columns];

for (int i = 0; i < chars.GetLength(0); i++)
{

    for (int j = i; j < chars.GetLength(1); j++)
    {
        WriteLine("Enter char");
        chars[i, j] = Convert.ToChar(ReadLine()!);
    }
}
Print2DArray(chars, txt2: "");