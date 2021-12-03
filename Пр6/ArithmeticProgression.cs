using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6
{
    public class ArithmeticProgression : IIndexableSeries
    {
        double IIndexable.a => throw new NotImplementedException();
        double IIndexable.b => throw new NotImplementedException();
        double IIndexable.c => throw new NotImplementedException();
        public ArithmeticProgression (double a, double c,double b)
        {
            _a = a;
            _c = c;
            _b = b;
        }
        double _c;
        double _a;
        double _b;
        public double GetCurrent()
        {
            _a = _a + _b;
            return _a;
        }

        public bool MoveNext()
        {
            return true;
        }

        public void Reset()
        {
            _a = _c;
        }
    }
}
