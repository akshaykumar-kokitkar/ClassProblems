using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class HighestNumFromArray
    {
        static int size = Convert.ToInt32(Console.ReadLine());
        int[] intarray = new int[size];
        public void GetHighestFromArray()
        {
            int max = intarray[0];
            Console.WriteLine("enter array");
            for (int i = 0; i < intarray.Length; i++)
            {
                intarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] > max)
                    max = intarray[i];
            }
            Console.WriteLine("Largest number in given array is : " + max);
        }
    }
}
