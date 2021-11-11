using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем два массива
            int[] myArr = new int[5];
            int[,] myTwoArr = new int[5, 6];
            Random ran = new Random();
            //Инициализируем массивы
            for (int i = 1; i <= 5; i++)
            {
                myArr[i - 1] = ran.Next(1, 20);
                for (int j = 1; j <= 6; j++)
                    myTwoArr[i - 1, j - 1] = ran.Next(10, 30);
            }
            //Ввычисляем квадрат каждого элемента одномерного массива
            foreach (int f in myArr)
                Console.WriteLine("{0} в квадрате равно {1}", f, f * f);
            Console.WriteLine();
            //Вычислим сумма элементов многомерного массива
            int sum = 0;
            foreach (int f2 in myTwoArr)
                sum += f2;
            Console.WriteLine("Сумма 2d массива: {0}", sum);
            Console.ReadLine();
        }
    }
}
