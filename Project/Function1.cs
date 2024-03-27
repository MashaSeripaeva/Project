using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class Function1
    {
        public static void main()
        {
            int a = 5;
            int b= 6;
            gg( a,b);
        }
        static void gg(  params int[] arr)
        {
            if (arr[0]>0)
            foreach (var item in arr)
            {
                item.Print();
            }
        }
    }
} 
