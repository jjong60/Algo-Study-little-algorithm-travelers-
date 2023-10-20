using System;

class Algorithm
{
    static void Main()
    {
        int input1 = int.Parse(Console.ReadLine());
        int input2 = input1, cnt = 0 ;
        while (true)
        {
            int a = input1 / 10;
            int b = input1 % 10;
            input1 = (b * 10) + (a + b) % 10;
            cnt++;
            if (input1 == input2)
                break;
        }
        Console.WriteLine(cnt);
    }
}