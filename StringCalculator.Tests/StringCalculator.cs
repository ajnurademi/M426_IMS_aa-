using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] numberArray = numbers.Split(',', '\n');


            int sum = 0;
            foreach (string number in numberArray)
            {
                sum += int.Parse(number);
            }

            return sum;
        }
    }
}
