using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void OneOrTwo (int value1, int value2)
        {
          if (value1 > value2)
          {
          Console.WriteLine("Число " + value1 + " больше числа " + value2);
          }
          if (value1 < value2)
          {
          Console.WriteLine("Число " + value2 + " больше числа " + value1);
          }
        }
        public static void Pavno(int value1, int value2)
        {
           if (value1 == value2)
           {
           Console.WriteLine("Числа равны");
           }
            else Console.WriteLine("Вы лох, числа неодинаковые");
            
        }
        public static void Tree(int value1, int value2)
        {
            if ((value1 + value2) % 3 == 0)
            {
            Console.WriteLine("Ура, сумма чисел кратна 3 ");
            }
            else Console.WriteLine("Сумма не кратна 3 ");
        }
    }
    
}
