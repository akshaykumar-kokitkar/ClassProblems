using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class PalindromeString
    {
        string s;
        string reverse = "";
        
        public PalindromeString(string str)
        {
            this.s = str;
        }

        public void GetString()
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }

            if(reverse == s)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}
