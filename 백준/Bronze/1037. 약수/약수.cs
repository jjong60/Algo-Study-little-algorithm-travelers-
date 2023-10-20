using System;

class Algorithm
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string[] a = Console.ReadLine().Split();
        int[] A = Array.ConvertAll(a, s=>int.Parse(s));
        Array.Sort(A);
        if (input == 1)
            Console.WriteLine(A[0] * A[0]);
        else
            Console.WriteLine(A[input - 1] * A[0]);
    }
}