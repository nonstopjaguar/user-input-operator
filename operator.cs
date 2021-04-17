using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name:");
            var name = Console.ReadLine();
            Console.Write("1st Number:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("2nd Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Hello, LANCE!");
            Console.WriteLine();



            int numbers = m;
            
            if (numbers < n)
            {
                Console.WriteLine("{0} is less than " + n + "", numbers);
            }
            else if (numbers > n)
            {
                Console.WriteLine("{0} is greater than " + n + "", numbers);
            }
            else

            {
                Console.WriteLine("" + m + " is equal to " + n + "");
            }

            Console.ReadKey();
        }
    }
}
