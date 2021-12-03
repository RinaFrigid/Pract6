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
            double a, b, c;
            a =c= double.Parse(Console.ReadLine());
            b= double.Parse(Console.ReadLine());
            int i= int.Parse(Console.ReadLine());
            ArithmeticProgression AP = new ArithmeticProgression(a,c);
            GeometricProgression GP = new GeometricProgression(a, c, b);
            Console.WriteLine(a);
            PrintSeries(GP, i);
            PrintIndexable(AP, i);
            /*ISeries[] series = new ISeries[2];
            series[0] = GP;
            series[1] = AP;*/


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
