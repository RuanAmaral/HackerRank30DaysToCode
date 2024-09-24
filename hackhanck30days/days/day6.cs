class day6
{
    public static void day6Main()
    {
        int NS;
        List<string> Sts = new List<string>();
        NS = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < NS; i++)
        {
            string s;
            s = Console.ReadLine();
            Sts.Add(s);
        }

        foreach (string s in Sts)
        {
            string allSEv = "", allSOdd = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    allSEv = allSEv + s.Substring(i, 1);
                }
                else
                {
                    allSOdd = allSOdd + s.Substring(i, 1);
                }
            }

            Console.WriteLine(allSEv + " " + allSOdd);
        }

    }
}