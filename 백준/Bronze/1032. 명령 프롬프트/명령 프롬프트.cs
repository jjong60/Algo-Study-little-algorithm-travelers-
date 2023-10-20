using System;
using System.Text;

class Algorithm
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string s = null;
        StringBuilder sb = new StringBuilder();
        string[] fileName = new string[input];
        for (int i = 0; i < input; i++)
            fileName[i] = Console.ReadLine();

        for (int i = 0;i < fileName[0].Length; i++)
        {
            s = null;
            for (int j = 1; j < input; j++)
            {
                if (fileName[0][i] != fileName[j][i])
                {
                    s = "?";
                    break;
                }
            }
            if (s == null)
                s = fileName[0][i].ToString();
            sb.Append(s);
        }
        Console.WriteLine(sb);
    }
}