using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y003
{
    struct Point
    {
        public int x;
        public int y;

    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Point p1, p2;
             p1.x = 20;
             p1.y = 30;
             Console.WriteLine("{0},{1}", p1.x, p1.y);
             p2 = p1;
             p1.x++;
             */
            int p,pp;
            double g,gg;
            p = Convert.ToInt32(Console.ReadLine());
            pp = Int32.Parse(Console.ReadLine());
            g = Convert.ToDouble(Console.ReadLine());
            gg = Double.Parse(Console.ReadLine());
            //type_name var_name[= init];
            int n1, n2 = 11;
            double n3 = 5, n4;
            short n5 = 10, n6;
            n1 = n5;
            n4 = n2;
            n1 = (int)n3;
            n6 = (short)n2;
        }
    }
}
