using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

const int n = 5;
int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Enter Element : ", i + 1);
    string str = Console.ReadLine();
    numbers[i] = int.Parse(str);

}

Console.Write("\nODD NUMBERS : ");
for (int i = 0; i < n; i++)
{
    if (numbers[i] % 2 == 1)
        Console.Write("{0} ", numbers[i]);
}


Console.Write("\nEVEN NUMBERS : ");
for (int i = 0; i < n; i++)
{
    if (numbers[i] % 2 == 0)
        Console.Write("{0} ", numbers[i]);
}
