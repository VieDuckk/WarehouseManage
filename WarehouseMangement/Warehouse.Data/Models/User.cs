using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid IdRole { get; set; }
        public Role Role { get; set; }
        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
