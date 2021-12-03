using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6
{
    class GeometricProgression : IIndexableSeries
    {
        double IIndexable.a => throw new NotImplementedException();
        double IIndexable.b => throw new NotImplementedException();
        double IIndexable.c => throw new NotImplementedException();
        public GeometricProgression(double a, double c, double b)
        {
            _c = c;
            _a = a;
            _b = b;
        }
        double _c;
        double _a;
        double _b;
        double ISeries.GetCurrent()
        {
            _a *= _b;
            return _a;
        }

        bool ISeries.MoveNext()
        {
            return true;
        }

        public void Reset()
        {
            _a = _c;
        }
    }
}
