
using System;
using static System.Console;
class MyClass
{
    static void Main()
    {
        Int16 A = 1;
        Int16 B = 5;
        for (int i = A; i < B+1; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Write(i);
            }
            WriteLine();
        }
    }
}