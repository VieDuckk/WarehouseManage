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
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne<Bill>(c => c.Bill).WithMany(c => c.BillDetails).HasForeignKey(c => c.IdBill);
            builder.HasOne<Product>(c => c.Product).WithMany(c => c.BillDetails).HasForeignKey(c => c.IdProduct);
        }
    }
}
