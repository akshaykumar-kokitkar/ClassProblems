using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class ReverseNumber
    {
        int number;
        int reverse = 0;

        public ReverseNumber(int number)
        {
            this.number = number;
        }

        public void GetReverseNumber()
        {
            while(number > 0)
            {
                int remainder = number % 10; //save remainder
                reverse  = (reverse * 10) + remainder; //save next number
                number = number / 10;
            }
            Console.WriteLine("reverse: " + reverse);
        }
    }
    
}
