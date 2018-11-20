using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Using the C# language, have the function TimeConvert(num) take the num parameter being passed 
 * and return the number of hours and minutes the parameter converts to 
 * (ie. if num = 63 then the output should be 1:3). 
 * 
 * Separate the number of hours and minutes with a colon. 
 */


namespace ConsoleApp1
{
    class MainClass
    {
        public static string TimeConvert(int num)
        {
            int hours;
            int minutes;

            hours = (num / 60);
            minutes = num % 60;
            
            if (minutes<10)
            {
                return hours + ":0" + minutes;
            }
            else
            {
                return ""+hours + ":"+ minutes;
            }
          
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(TimeConvert(Convert.ToInt32(Console.ReadLine())));
        }

    }
}
