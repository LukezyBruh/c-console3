/* Груеева И.Д. Вариант 2, 15.02.2022
Ввести двузначное число. Определить: 
а) какая из его цифр больше: первая или вторая;
б) одинаковы ли его цифры?
в) кратна ли трём сумма его цифр;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;



namespace Практическая_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            Console.WriteLine("Введите двузначное число");
            v1 = Convert.ToInt32(Console.ReadLine());
            if (9 < v1 && v1 < 100)
            {
                v2 = v1 % 10;
                v1 /= 10;
                Class1.OneOrTwo(v1, v2);
                Class1.Pavno(v1, v2);
                Class1.Tree(v1, v2);
            }
            else Console.WriteLine("Не двузначное число");
            Console.ReadKey();
        }
    }
}
