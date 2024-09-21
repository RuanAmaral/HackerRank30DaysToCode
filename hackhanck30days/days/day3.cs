class day3Solution
{
    public static void Day3Main()
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        if (N % 2 == 1 || (N > 5 && N <= 20))
        {
            Console.WriteLine("Weird");
        }
        else if (N > 20 || N < 5)
        {
            Console.WriteLine("Not Weird");
        }

    }
}