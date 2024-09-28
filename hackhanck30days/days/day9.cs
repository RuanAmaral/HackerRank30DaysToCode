class day9Solution
{

    public static void day9Main()
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = day9Result.factorial(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

class day9Result
{
    public static int factorial(int n)
    {
        if (!(n == 0))
        {
            return n * factorial(n - 1);
        }
        else
        {
            return 1;
        }
    }
}