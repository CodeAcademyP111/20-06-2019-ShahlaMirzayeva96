using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
         string  stri = "Cavide Eshq olsun Cavide Eshq olsun";
            EmptyString(stri);
        }
        static int EmptyString(string str)
        {
            int count = 0;
           char CountEmpty = ' ';
        
            for (int i = 0; i < str.Length; i++)
               
            {
                if (str[i] == CountEmpty)
                {
                    count++;
                }
            }


            Console.WriteLine(count);
            return count;
        }
    }
}
