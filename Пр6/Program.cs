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
            a = c = double.Parse(Console.ReadLine());
            b= double.Parse(Console.ReadLine());
            int i= int.Parse(Console.ReadLine());
            GeometricProgression gP = new GeometricProgression(a,c);
            ArithmeticProgression aP = new ArithmeticProgression(a,c,b);
            Console.WriteLine(a);
            PrintSeries(gP, i);
            PrintIndexable(aP, i);
            ISeries[] series = new ISeries[2];
            series[0] = gP;
            series[1] = aP;

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
