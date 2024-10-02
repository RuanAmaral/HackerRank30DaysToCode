class day11
{
    public static void day11Main()
    {
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        
        int maxsum = -90;

        for (int i = 0; (i + 3) <= arr.Count; i++)
        {
            for (int j = 0; (j + 3) <= arr.Count; j++)
            {
                int sumNow = arr[i][j] + arr[i][j+1] + arr[i][j+2];
                sumNow += arr[i+1][j+1]; 
                sumNow += arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];

                if (maxsum < sumNow)
                {
                    maxsum = sumNow;
                }

            }
        }

        Console.WriteLine(maxsum);

    }
}