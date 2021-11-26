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
            GeometricProgression gP = new GeometricProgression();
            ArithmeticProgression aP = new ArithmeticProgression();
            PrintSeries(gP, 6);
            PrintIndexable(aP, 9);
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
