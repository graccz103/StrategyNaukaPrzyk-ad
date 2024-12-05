using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNaukaPrzykład
{
    public class PrioritySortingStrategy : ISortingStrategy
    {
        public IEnumerable<Task> Sort(IEnumerable<Task> tasks)
        {
            var priorityOrder = new Dictionary<string, int>
        {
            { "High", 1 },
            { "Medium", 2 },
            { "Low", 3 }
        };

            return tasks.OrderBy(task => priorityOrder.ContainsKey(task.Priority)
                                         ? priorityOrder[task.Priority]
                                         : int.MaxValue);
        }
    }

}
