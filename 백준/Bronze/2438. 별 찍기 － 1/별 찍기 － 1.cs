using System;

class Algorithm
{
    static void Main()
    {
        int Input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= Input; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}