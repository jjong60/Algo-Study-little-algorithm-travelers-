using System;

class Algorithm
{
    static void Main()
    {
        string[] sInput = Console.ReadLine().Split();
        int[] input = Array.ConvertAll(sInput, s => int.Parse(s));
        int res = input.Min();
        int cnt = 0;
        while (true)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (res % input[i] == 0)
                {
                    cnt++;
                }
            }
            if (cnt >= 3)
                break;
            cnt = 0;
            res++;
        }
        Console.WriteLine(res);
    }
}