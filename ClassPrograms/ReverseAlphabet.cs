using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class ReverseAlphabet
    {
        int size;
        string input;

        public void GetReverseAlphabet()
        {
            Console.WriteLine("Enter number of alphabet you want reverse");
            size =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter word");
            input = Console.ReadLine();

            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(input[i] + "");
            }
        }
    }
}
