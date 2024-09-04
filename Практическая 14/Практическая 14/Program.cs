/* Гуреева И.Д. ИСП-23 Вариант 2
Описать функцию RootsCount(A, B, C) целого типа, определяющую количество 
корней квадратного уравнения A·x2 + B·x + C = 0 (A, B, C — вещественные параметры, A>0). 
С ее помощью найти количество корней для каждого из трех квадратных уравнений с 
данными коэффициентами. Количество корней определять по значению дискриминанта: D = B2– 4·A·C. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_14
{ 
    class Program
    {
        static double Gg(double A, double B, double C)
        {
            double x = 0;
            x = Math.Pow(B, 2) - 4 * A * C;
            return x;
        }
        static void Main(string[] args)
        {
            double dis,
                   A, 
                   B, 
                   C;
            Console.WriteLine("Введите значение а");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            C = Convert.ToInt32(Console.ReadLine());

            if (A > 0)
            {
                dis = Gg(A, B, C);
                Console.WriteLine("" + dis);

                if (dis == 0)
                {
                    Console.WriteLine("Один корень");
                }
                if (dis > 0)
                {
                    Console.WriteLine("Два корня");
                }
                if (dis < 0)
                {
                    Console.WriteLine("Нет корней");
                }
            }

            Console.ReadKey();
        }
    }
}
