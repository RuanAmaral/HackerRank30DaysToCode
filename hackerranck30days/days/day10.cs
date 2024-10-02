class day10
{
    public static void day10Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        if (n != 0)
        {
            string binary = Convert.ToString(n, 2);

            List<string> binaryList = binary.Split("0").ToList();

            Console.WriteLine(binaryList.Max().Count());
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}