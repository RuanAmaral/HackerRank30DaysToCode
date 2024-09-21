class day2Result
{
      /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip, tax, total_cost;
        tip = (meal_cost/100) * tip_percent;
        tax = (Convert.ToDouble(tax_percent)/100) * meal_cost;
        total_cost = meal_cost + tip + tax;
        Console.WriteLine(Math.Round(total_cost));
    }
}

class day2Solution
{
    public static void day2SolutionMethod(){

        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        day2Result.solve(meal_cost, tip_percent, tax_percent);
        
        //To harckerHanck use line of down
        // Result.solve(meal_cost, tip_percent, tax_percent);


    }
}