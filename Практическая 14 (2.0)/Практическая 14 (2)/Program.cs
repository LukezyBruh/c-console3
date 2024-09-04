/*Гуреевой И.Д. Вариант 2 10.02.2022
 *Описать процедуру PowerA234(A, B, C, D), вычисляющую вторую, третью и 
четвертую степень числа A и возвращающую эти степени соответственно в переменных 
B, C и D (A — входной, B, C, D — выходные параметры; все параметры являются 
вещественными). С помощью этой процедуры найти вторую, третью и четвертую степень
пяти данных чисел.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_14__2_
{
    class Program
    {
        static void PowerA234(in double A, out double B, out double C, out double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
        }

        static void Main(string[] args)
        {
            double ValueA, ValueB, ValueC, ValueD;

            Console.WriteLine("Введите число = ");
            ValueA = Convert.ToInt32(Console.ReadLine());
            PowerA234(in ValueA, out ValueB, out ValueC, out ValueD);
            Console.WriteLine("А = " + ValueB);
            Console.WriteLine("А = " + ValueC);
            Console.WriteLine("А = " + ValueD);
            Console.ReadKey();
        }
    }
}
