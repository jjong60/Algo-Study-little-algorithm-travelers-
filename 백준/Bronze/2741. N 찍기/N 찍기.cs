using System;
using System.Text;

class Algorithm
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        StringBuilder SB = new StringBuilder();
        
        for (int i = 1; i <= N; i++)
        {
            SB.AppendLine(i.ToString());
        }
        Console.WriteLine(SB);
    }
}