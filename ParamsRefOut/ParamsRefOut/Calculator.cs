using System;
using System.Collections.Generic;
using System.Text;

namespace ParamsRefOut
{
    class Calculator
    {

        public static void Triple(ref int x) {
            x = x * 3; 
        }

        public static void Triple2(int x, out int triple) {

            triple = x * 3;
        
        }
    }
}
