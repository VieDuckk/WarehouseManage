using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class InventoryStatus
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
    }
}
