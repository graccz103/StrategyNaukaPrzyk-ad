using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNaukaPrzykład
{
    public class TaskManager
    {
        private ISortingStrategy _sortingStrategy;

        public TaskManager(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public void SetSortingStrategy(ISortingStrategy strategy)
        {
            _sortingStrategy = strategy;
        }

        public IEnumerable<Task> SortTasks(IEnumerable<Task> tasks)
        {
            return _sortingStrategy.Sort(tasks);
        }
    }


}
