using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Programs
{
    internal class Perimeter
    {
       public static void Main()
        {
            Console.WriteLine("enter length");
           Decimal length= Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("enter Breadth");
           Decimal Breadth= Convert.ToDecimal(Console.ReadLine());

            decimal perimeter = 2 * (length + Breadth);
            Console.WriteLine("perimeter of rectangle is" + perimeter);
            Console.ReadLine();
        }
    }
}
