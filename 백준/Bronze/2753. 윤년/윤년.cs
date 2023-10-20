class Algorithm
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        if (input % 4 == 0 )
        {
            if (input % 100 != 0)
                Console.WriteLine("1");
            else if (input % 400 == 0)
                Console.WriteLine("1");
            else 
                Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}