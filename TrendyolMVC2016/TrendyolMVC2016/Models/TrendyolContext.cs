using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrendyolMVC2016.Models
{
    public class TrendyolContext : DbContext
    {
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Storage> Storages { get; set; }
    }
}