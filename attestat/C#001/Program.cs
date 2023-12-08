using System.Runtime.ExceptionServices;
using static MyMethods;
using static System.Console;


void PrintIntFirstTolast(int first, int last)
{
    if (first > last)
    {
        return;
    }


    PrintIntFirstTolast(first + 1, last);
    Write(first + " ");

}



int first = ReadInt("enter first number");
int last = ReadInt("enter last number");

PrintIntFirstTolast(first, last);