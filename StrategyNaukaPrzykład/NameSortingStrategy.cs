using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNaukaPrzykład
{
    public class NameSortingStrategy : ISortingStrategy
    {
        public IEnumerable<Task> Sort(IEnumerable<Task> tasks)
        {
            return tasks.OrderBy(task => task.Name);
        }
    }

}
