﻿using System;
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
                Console.WriteLine(indexable.GetCurrent());
            }
        }
    }
}
