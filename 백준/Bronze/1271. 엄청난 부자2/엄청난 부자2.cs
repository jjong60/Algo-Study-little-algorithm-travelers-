using System;
using System.Numerics;

class SumAlgorithm
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        BigInteger A = BigInteger.Parse(input[0]);
        BigInteger B = BigInteger.Parse(input[1]);

        Console.WriteLine(A / B);
        Console.WriteLine(A % B);
    }
}