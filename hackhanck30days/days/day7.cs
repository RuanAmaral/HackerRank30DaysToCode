class day7
{
    public static void day7Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        arr.Reverse();

        foreach (var i in arr)
        {
            Console.Write($"{i} ");            
        }  
  
    }
}