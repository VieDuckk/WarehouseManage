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
    public class InventoryStatusConfiguration : IEntityTypeConfiguration<InventoryStatus>
    {
        public void Configure(EntityTypeBuilder<InventoryStatus> builder)
        {
            builder.HasKey(c => c.Id);
        }
    }
}
