Console.Write("Enter your name ");
string username = Console.ReadLine();
if (username.ToLower() == "masha")
{
    Console.WriteLine("Yay, it's Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.Write(username);
}