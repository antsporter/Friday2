using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Friday2Challenge
{
    class Convert
    {

        public void ReplaceNumbersWithStrings(int no1)
        {

            if (no1 >= 0 && no1 < 10000)
            {
                Console.WriteLine("Your number is: " + no1);
                Console.WriteLine("Converted to English is: " + IntToString(no1));
            }
            else
            {
                Console.WriteLine("Your number is: " + no1);
                Console.WriteLine("This number doesn't work for my logic!");
            }

        }

        private string IntToString(int number)
        {
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string words = "";

            if (number == 0)
            {
                return "zero";
            }

            if ((number / 1000) > 0) 
            {
                words += units[(number / 1000)] + " thousand ";
                number = number % 1000; 
            }

            if ((number / 100) > 0) 
            {
                words += units[(number / 100)] + " hundred ";
                number = number % 100; 
            }

            if (number > 0)
            {
                if (words != "")
                {
                    
                    words += "and ";
                }

                if (number < 20)
                {
                    words += units[number];
                }
                else
                {
                    
                    words += tens[number / 10];

                    if ((number % 10) > 0) 
                    {
                        words += " " + units[number % 10];
                    }
                }
            }
            return words;
        }


    }

}
