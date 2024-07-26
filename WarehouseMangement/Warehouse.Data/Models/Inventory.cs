using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public Guid IdProduct { get; set; }
        public Product Product { get; set; }
        public Guid IdUser { get; set; }
        public User User { get; set; }
        public Guid IdInventoryStatus { get; set; }
        public InventoryStatus InventoryStatus { get; set; }
        public int Quantity { get; set; }
        public int InventoryLimit { get; set; }
        public string? Location { get; set; }
    }
}
