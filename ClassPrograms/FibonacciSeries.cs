using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class FibonacciSeries
    {
        int n1 = 0;
        int n2 = 1;
        int n3;
        int number;

        public FibonacciSeries(int number)
        {
            this.number = number;
        }

        public void CalculateFibonacci()
        {
            Console.Write(n1 + " " + n2 + " ");

            for(int i = 2; i < number; ++i)
            {
                n3 =  n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2= n3;
            }
        }
    }
}
