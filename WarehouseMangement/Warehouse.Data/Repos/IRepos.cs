using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Repos
{
    public interface IRepos<T>
    {
        public IEnumerable<T> GetAllItems();
        public bool CreateItem(T item);
        public bool UpdateItem(T item);
        public bool DeleteItem(T item);
    }
}
