using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class ReverseString
    {
        string str = "";
        string reverse;
        public ReverseString(string str)
        {
            this.str = str;
        }

        public void GetReverseString()
        {
            for(int i=str.Length-1; i>=0; i--)
            {
                Console.Write(str[i] + "");
            }
        }
    }
}
