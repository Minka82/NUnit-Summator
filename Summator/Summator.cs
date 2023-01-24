﻿using System;
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
        public static int Sum(int[] arr)
        {
            int sum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //Here the sample test
        public static void Test_SumTwoNumbers()
        {
            if (Sum(new int[] { 1, 3 }) != 3)
            {
                throw new Exception("1+2 != 3");
            }
            else
            {
                Console.WriteLine("Test Pass"!);
            }





        }
    }
} 


        
    

