using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS4._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int plus = 0;
            int minus = 0;
            int v = 0;
            do
            {
                Console.WriteLine("Ввести число. Выход 0 (ноль)");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    plus++;
                }
                else if (n < 0)
                {
                    minus++;
                }                
            } while (n != 0);
            if (plus>minus)
            {
                Console.WriteLine("количество положительных = {0}", plus);
            }
            else if (plus == minus)
            {
                Console.WriteLine("количество отрицательных равно количеству положительных, =  {0}", minus);
            }
            else
            Console.WriteLine("количество отрицательных = {0}", minus);
            Console.ReadKey();
        }

    }
}
