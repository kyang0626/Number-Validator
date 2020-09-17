using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Number_Validator
{
    class Validator1
    {
            public static bool TelephoneValidator(string digit)
            {
                // remove non-digits and space
                string shortenNum = Regex.Replace(digit, @"[^0-9a-zA-Z]+", "");
                Console.WriteLine(shortenNum);

                if (shortenNum.Length == 10 || shortenNum.Length == 11 || shortenNum == "911")
                {
                    Console.WriteLine("This is a number");
                    return true;
                }
                else
                {
                    Console.WriteLine("This is not a number");
                    return false;

                }
            }
    }

}
