using System; // 1236

class Algorithm
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        char[][] castle = new char[50][];
        for (int i = 0; i < N; i++)
        {
            castle[i] = Console.ReadLine().ToCharArray();
        }

        int[] rows = new int[N];
        int[] cols = new int[M];
        int guard_row = 0, guard_col = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++) 
            {
                if (castle[i][j] == 'X')
                {
                    rows[i] = 1;
                    cols[j] = 1;
                }
            }
        }
        for (int i = 0; i < N; i++) 
        {
            if (rows[i] == 0)
            {
                guard_row++;
            }
        }
        for (int i = 0; i < M; i++)
        {
            if (cols[i] == 0)
            {
                guard_col++;
            }
        }
        if (guard_row > guard_col)
        {
            Console.WriteLine(guard_row);
        }
        else
        {
            Console.WriteLine(guard_col);
        }
        
    }
}
