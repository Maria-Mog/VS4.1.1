using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS4._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести сторону прямоугольника А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести сторону прямоугольника В");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввести сторону квадрата С");
            int C = Convert.ToInt32(Console.ReadLine());
            int vertC = 0;
            int gorizC = 0;
            int kol = 0;
            while (A >= C)
            {
                A-=C;
                gorizC++; //считает ко-во отрезков по горизонтали/вертикали
            }
            while (B >= C)
            {
               B-=C;
                vertC++; //считает ко-во отрезков по горизонтали/вертикали
            }
            for (int i = 0; i < gorizC; i++)
            {
                kol += vertC;                
            }
            Console.WriteLine("количество квадратов = {0}", kol);
            Console.ReadKey();

        }


    }
}
