using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNaukaPrzykład
{
    public interface ISortingStrategy
    {
        IEnumerable<Task> Sort(IEnumerable<Task> tasks);
    }
}
