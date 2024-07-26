using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class CategoryGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public ICollection<Category> Categories { get; set;}
    }
}
