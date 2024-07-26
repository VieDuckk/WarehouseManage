﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid IdCategoryGroup { get; set; }
        public CategoryGroup CategoryGroup { get; set; }
        public bool Status { get; set; }
    }
}
