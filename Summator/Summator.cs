using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        //Test mathod for sum of array from numbers
        public static long Sum(int[] arr)
        {


            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            //return sum
            return sum;


        }
        public static int Average(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            //return sum
            return sum / arr.Length;



        }
    }
}




        
    

