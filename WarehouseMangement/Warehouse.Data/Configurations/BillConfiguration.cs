using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Models;

namespace Warehouse.Data.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Partner>(c => c.Partner).WithMany(c => c.Bills).HasForeignKey(c => c.IdPartner);
            builder.HasOne<User>(c => c.User).WithMany(c => c.Bills).HasForeignKey(c => c.IdUser);
        }
    }
}
