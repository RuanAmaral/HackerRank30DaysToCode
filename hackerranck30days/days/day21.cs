using System;

class Day21Printer
{

	/**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
    // Write your code here
    
    public static void Day21PrintArray<T>(T[] Array){
         foreach(T e in Array){
            Console.WriteLine(e);
         }
    }
        


    static void Day21Main()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] intArray = new int[n];
		for (int i = 0; i < n; i++)
		{
			intArray[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		n = Convert.ToInt32(Console.ReadLine());
		string[] stringArray = new string[n];
		for (int i = 0; i < n; i++)
		{
			stringArray[i] = Console.ReadLine();
		}
		
		Day21PrintArray<Int32>(intArray);
		Day21PrintArray<String>(stringArray);
	}
}