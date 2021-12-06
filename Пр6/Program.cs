using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;//переменные
            double t = 0;
            Console.Write("Укажите первый элемент прогрессии: ");//ввод значений пользователем
            a =c= double.Parse(Console.ReadLine());
            Console.Write("Коэффициент прогрессии: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Количество элементов: ");
            int i= int.Parse(Console.ReadLine());
            ArithmeticProgression AP = new ArithmeticProgression(a,c,b);
            GeometricProgression GP = new GeometricProgression(a, c, b,t);
            Console.WriteLine("Геометрическая прогрессия:");
            PrintSeries(GP, i);
            Console.WriteLine("Арифметическая прогрессия:");
            PrintSeries(AP, i);
            Console.ReadKey();
        }
        public static void PrintSeries(ISeries series, int count)
        {
            for (int i=0; i<count; i++)
            {
                series.MoveNext();
                Console.WriteLine(series.GetCurrent());
            }
        }
        public static void PrintIndexable(IIndexable indexable, int count)
        {
            for (int i = 0; i < count; i++)
            {
                indexable.ToString();
                Console.WriteLine("{0}\n",indexable.GetType());
            }
        }
    }
}
