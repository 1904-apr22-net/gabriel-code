using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Calculator
    {
        public void calc(int n)
        {
            
            for (int x = n; x > 0; x--)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
