using System;
using System.Collections.Generic;
using System.IO;
class day26 {
    static void day26Main() {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        // this conversion is better
        //  var r = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToList();
        // var e = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToList();
        int fine =0;
        List<string> dateRetunedList = Console.ReadLine().Split(" ").ToList();
        List<string> dateDueList = Console.ReadLine().Split(" ").ToList();
        
        DateTime dateReturn = new DateTime(Convert.ToInt32(dateRetunedList[2]),Convert.ToInt32(dateRetunedList[1]),Convert.ToInt32(dateRetunedList[0]));
        
          DateTime dateDue = new DateTime(Convert.ToInt32(dateDueList[2]),Convert.ToInt32(dateDueList[1]),Convert.ToInt32(dateDueList[0]));
          
          if(dateDue>=dateReturn){
              fine =0;
          }else if (dateReturn.Day > dateDue.Day && dateDue.Month == dateReturn.Month && dateReturn.Year == dateDue.Year){
              fine = 15 * (dateReturn.Day - dateDue.Day) ;
          }else if( dateDue.Month < dateReturn.Month && dateReturn.Year == dateDue.Year){
              fine =500 * (dateReturn.Month - dateDue.Month);
          }else{
              fine=10000;
          }
        
        Console.WriteLine(fine);
        
        
    }
}
