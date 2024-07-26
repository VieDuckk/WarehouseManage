using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public Guid IdPartner { get; set; }
        public Partner Partner { get; set; }
        public Guid IdUser { get; set; }
        public User User { get; set; }
        public int? UpdateBy { get; set; }
        public int CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int BillType { get; set; }

        public ICollection<BillDetail> BillDetails { get; set; }
     
    }

}
