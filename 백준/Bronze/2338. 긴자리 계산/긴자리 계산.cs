using System;
using System.Numerics;

class Algorithm
{
    static void Main()
    {
        BigInteger A = BigInteger.Parse(Console.ReadLine());
        BigInteger B = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(A + B);
        Console.WriteLine(A - B);
        Console.WriteLine(A * B);
    }
}