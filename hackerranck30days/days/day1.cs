class day1
{
    public static void day1Task(){
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int myInt;
        double myDouble;
        string myString;
        // Read and save an integer, double, and String to your variables.

        myInt = Convert.ToInt32(Console.ReadLine());
        myDouble = Convert.ToDouble(Console.ReadLine());
        myString = Console.ReadLine();

        // Print the sum of both integer variables on a new line.

        Console.WriteLine(i + myInt);
        Console.WriteLine(String.Format("{0:0.0#}",(d + myDouble)));
        Console.WriteLine(s + myString);


        // Print the sum of the double variables on a new line.

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
    }
}