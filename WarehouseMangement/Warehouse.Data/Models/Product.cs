using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Guid IdCategory { get; set; }
        public Category Category { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal ImportPrice { get; set; }
        public string Image { get; set; }
        public int? UpdateBy { get; set; }
        public int CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int Weight { get; set; }
        public string Unit { get; set; }
        public Boolean Status { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
