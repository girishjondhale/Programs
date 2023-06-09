using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius");
            double rad=Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * rad * rad;
            Console.WriteLine("Area of circle is:" + area);
        }
    }
}
