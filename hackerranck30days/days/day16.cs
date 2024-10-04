class day16
{
    public static void day16Main()
    {
        string S = Console.ReadLine();

        Console.WriteLine(Int32.TryParse(S, out int ds) ? Convert.ToInt32(S) : "Bad String");

    }
}