using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class PalindromeNumber
    {
        int number;
        int reverse;
        int sum = 0;
        int temp;
        
        public PalindromeNumber(int number)
        {
            this.number = number;
        }

        public void GetPalindrome()
        {
            int remainder  = number % 10;
            sum = (sum * 10) + reverse;
            number = number / 10;

            if(temp == sum)
            {
                Console.WriteLine("number is palindrome");

            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }
        }

    }
}
