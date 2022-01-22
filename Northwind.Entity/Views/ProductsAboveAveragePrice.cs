using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entity.Views
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
