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
        public GeometricProgression(double a, double c, double b, double t)
        {
            _c = c;
            _a = a;
            _b = b;
            _t = t;
        }
        double _c;
        double _a;
        double _b;
        double _t;
        double ISeries.GetCurrent()
        {
            _a = Math.Pow(_b,_t);
            _t++;
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
