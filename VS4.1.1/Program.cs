using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int N = Convert.ToInt32(Console.ReadLine());          
            int sum=0;
            
            for (int i = 1, k = 1; i <= N; i++, k += 2)
            {
                sum += k;
                Console.WriteLine("число {0}  квадрат числа {1}", i, sum);
            }            
            Console.ReadKey();
            {
                
            }
        }
    }

}


