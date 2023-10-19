using System;

class Algorithm
{
    static void Main()
    {
        string[] Input = Console.ReadLine().Split();
        int n = int.Parse(Input[0]);
        int m = int.Parse(Input[1]);

        int[,] A = new int[n, m];
        int[,] B = new int[n, m];


        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                A[i, j] = int.Parse(line[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                B[i, j] = int.Parse(line[j]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(A[i, j] + B[i, j] + " ");
            }
            Console.Write("\n");
        }
    }
}