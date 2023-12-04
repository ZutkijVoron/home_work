Console.WriteLine("enter string");
string? str = Console.ReadLine();
char[] chars = { 'e', 'y', 'u', 'i', 'o', 'a' };
int count = 0;
for (int i = 0; i < str!.Length; i++)
{
    for (int j = 0; j < chars.Length; j++)
    {
        if (str[i] == chars[j])
        {
            count++;
            break;
        }
    }
}
System.Console.WriteLine(count);




