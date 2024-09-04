/* Гуреева И.Д. 11.12.2021
 Составить программу, которая считывает с клавиатуры числа и записывает их в 
файл. Считывать числа до тех пор, пока не введено число 0. Далее считать числа из файла 
и рассчитать сумму чисел. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Практическая_13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inFile; 
            StreamWriter outFile;

            string a;
            int x = 1, sum = 0;
            Console.WriteLine("Введите числа = ");
            outFile = new StreamWriter("bloxa.txt");
           
            while ( x != 0 )
            {
                x = Convert.ToInt32(Console.ReadLine());
                outFile.WriteLine(x);
            }
            outFile.Close();

            inFile = new StreamReader("bloxa.txt");
            while ((a = inFile.ReadLine()) != null)
            {
                x = Convert.ToInt32(a);
                sum = sum + x;
            }
            inFile.Close();
            Console.WriteLine("Сумма чисел = " + sum);
            Console.ReadKey();
        }
    }
}
