using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 2, 4, 8,19,29 };
            MiddleNum(arry);
        }
        static int MiddleNum (int[] arr)
        { int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                    result +=arr[i];
             
                
            }
            
            Console.WriteLine(result/arr.Length);



            return result;
        }
    }
}
