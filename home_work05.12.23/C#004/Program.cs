using static MyMethods;
using static System.Console;



WriteLine("enter string");
string str = ReadLine()!;
string[] words = str.Split(new char[] { ' ' });
string temp;
for (int i = 0; i < words.Length / 2; i++)
{
    temp = words[i];
    words[i] = words[words.Length - i - 1];
    words[words.Length - i - 1] = temp;
}
PrintArray(words, " ");