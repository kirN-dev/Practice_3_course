using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryArray
{
    public static class Practice
    {
        public static int SumEven(this LibraryArray.Array array)
        {
            int sum = 0;

            foreach (var element in array.ToArray())
            {
                if (element % 2 == 0)
                    sum += element;
            }

            return sum;
        }
    }
}
