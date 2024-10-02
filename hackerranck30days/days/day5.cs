class day5
{
    public static void day5Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n+ " x " + i + " = " + (i*n));
        }

    }
}