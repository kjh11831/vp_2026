using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Console.Write("a[]: ");
            foreach (var value in a)
                Console.Write(value + " ");

            int[] b = new int[] { 1, 2, 3 };
            Console.Write("\nb[]: ");
            for (int i = 0; i < 3; i++)
                Console.Write(b[i] + " ");

            int[] d = new int[3];
            d[0] = 1;
            d[1] = d[0] + 1;
            d[2] = d[1] + 1;
            Console.Write("\nd[]: ");
            foreach (int value in d)
                Console.Write(value + " ");
            Console.WriteLine();
        }
    }
}
