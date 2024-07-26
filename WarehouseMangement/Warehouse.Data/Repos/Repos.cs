using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Repos
{
    public class Repos<T> : IRepos<T> where T : class
    {
        public bool CreateItem(T item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
