class Difference
{
    private int[] elements;
    public int maximumDifference = 0;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        for (int i = 0; i < this.elements.Length; i++)
        {
            for (int j = i + 1; j < this.elements.Length; j++)
            {
                int Difference = this.elements[i] - this.elements[j];

                if (Difference < 0)
                {
                    Difference = -(Difference);
                }
                if (Difference > maximumDifference)
                {
                    this.maximumDifference = Difference;
                }

            }
        }
    }

    // Add your code here

} // End of Difference Class

class day14
{
    public static void day14Main()
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}

