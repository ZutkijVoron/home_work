using static MyMethods;
using static System.Console;


double Akkerman(double n, double m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}




double n = ReadDouble();
double m = ReadDouble();
Write(Akkerman(n, m));