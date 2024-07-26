using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Models;

namespace Warehouse.Data.Configurations
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne<Product>(c => c.Product).WithMany(c => c.Inventories).HasForeignKey(c => c.IdProduct);
            builder.HasOne<User>(c => c.User).WithMany(c => c.Inventories).HasForeignKey(c => c.IdUser);
            builder.HasOne<InventoryStatus>(c => c.InventoryStatus).WithMany(c => c.Inventories).HasForeignKey(c => c.IdInventoryStatus);
        }
    }
}
