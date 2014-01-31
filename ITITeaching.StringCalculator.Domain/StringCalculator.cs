using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITITeaching.StringCalculator.Domain
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            List<string> seperators = new List<string>() { ",", "\n" };

            // check for new seperators and add if need be
            if (input.StartsWith("//") && input[3] == '\n') {
                seperators.Add(input[2].ToString());
                input = input.Replace("//", "");
            }

            // get an empty string
            if (string.IsNullOrEmpty(input))
                return 0;
            // handle two numbers
            else if (input.Contains(seperators.ToArray()))
            {
                // do split method
                string[] numbers = input.Split(seperators.ToArray(),StringSplitOptions.RemoveEmptyEntries);
                int sum = 0;
                foreach (string num in numbers)
                {
                    sum += int.Parse(num);
                }
                return sum;

            }
            else // handle a single number
                return int.Parse(input);
        }
    }

    public static class StringExtensions {
        public static bool Contains(this string input, string[] containsLists) {
            foreach (string containKey in containsLists)
            {
                if (input.Contains(containKey))
                    return true;
            }

            return false;
        }
    }
}
