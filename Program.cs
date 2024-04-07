class Program
{
    static void Fibonacci(int n)
    {
        int[] fibSeq = new int[n + 1];
        if(n <= 0)
        {
            Console.WriteLine("Error");
            return;
        }
        fibSeq[0] = 0;
        fibSeq[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fibSeq[i] = fibSeq[i - 1] + fibSeq[i - 2];
        }

        int seqSum = 0;
        for (int i = 0; i < fibSeq.Length; i++)
        {
            seqSum += fibSeq[i];
        }
        Console.WriteLine($"The {n}th term of the Fibonacci sequence is: {fibSeq[n]}");
        Console.WriteLine($"The sum of all terms in the sequence up to the {n}th term is: {seqSum}");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the term of Fibonacci sequence you want to find: ");
        string input = Console.ReadLine();
        if(input == null)
        {
            Fibonacci(0);
        }
        else
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                {
                    Fibonacci(0);
                    return;
                }
            }
            int n = int.Parse(input);
            Fibonacci(n);
        }
    }
}
