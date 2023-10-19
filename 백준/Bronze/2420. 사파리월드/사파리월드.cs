using System;
using System.Numerics;

class Algorithm
{
    static void Main()
    {
        string[] Input = Console.ReadLine().Split();
        BigInteger A = BigInteger.Parse(Input[0]);
        BigInteger B = BigInteger.Parse(Input[1]);


        if (A - B < 0)
        {
            Console.WriteLine((A - B) * (-1));
        }
        else
        {
            Console.WriteLine(A - B);
        }
    }
}