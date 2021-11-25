using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр6
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
