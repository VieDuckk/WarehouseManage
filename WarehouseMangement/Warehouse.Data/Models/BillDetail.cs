using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class BillDetail
    {
        public Guid Id { get; set; }
        public Guid IdProduct { get; set; }
        public Product Product { get; set; }
        public Guid IdBill{ get; set; }
        public Bill Bill { get; set; }
        public int Quantity { get; set; }

    }
}
