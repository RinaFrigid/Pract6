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
        public ArithmeticProgression (double a, double c)
        {
            _a = a;
            _c = c;
        }
        double _c;
        double _a;
        public double GetCurrent()
        {
            _a += _a;
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
