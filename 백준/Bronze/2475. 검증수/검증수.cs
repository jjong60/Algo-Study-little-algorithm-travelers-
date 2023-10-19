using System;

class Algorithm
{
    static void Main()
    {
        string[] Input = Console.ReadLine().Split();

        int sum = 0;

        for (int i = 0; i < Input.Length; i++)
        {
            sum += int.Parse(Input[i]) * int.Parse(Input[i]);
        }

        Console.WriteLine(sum % 10);
    }
}