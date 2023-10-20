using System;
class Algorithm
{
    static void Main()
    {
        string Input = Console.ReadLine();
        string Reverse = "";

        for (int i = 0; i < Input.Length; i++)
        {
            char c = Input[i];
            Reverse += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }

        Console.WriteLine(Reverse);
    }
}