using System.Collections.Generic;

class day8
{
    public static void day8Main()
    {
        //this mode, dont make run time exeption
        int NumCount = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

        for (int i = 0; i < NumCount; i++)
        {
            var phoneNumber = Console.ReadLine().Split(' ');
            phoneNumbers[phoneNumber[0]] = phoneNumber[1];
        }

        string searchValue;
        while ((searchValue = Console.ReadLine()) != null)
        {
            if (phoneNumbers.ContainsKey(searchValue))
            {
                Console.WriteLine(searchValue + "=" + phoneNumbers[searchValue]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        //This mode Cause Run time exepition
        //     int NumCount = Convert.ToInt32(Console.ReadLine());
        //     Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();
        //     List<string> searchValues = [];

        //     for (int i = 0; i < NumCount; i++)
        //     {
        //         string phoneNumber = Console.ReadLine();

        //         phoneNumbers.Add(phoneNumber.Split(" ")[0], phoneNumber.Split(" ")[1]);
        //     }

        //     for (int i = 0; i < NumCount; i++)
        //     {
        //         searchValues.Add(Console.ReadLine());
        //     }

        //     foreach (var i in searchValues)
        //     {
        //         if (phoneNumbers.ContainsKey(i))
        //         {
        //             Console.WriteLine(i + "=" + phoneNumbers[i]);
        //             phoneNumbers.Remove(i);
        //         }
        //         else
        //         {
        //             Console.WriteLine("Not found");
        //         }

        //     }

        // }
    }
}

