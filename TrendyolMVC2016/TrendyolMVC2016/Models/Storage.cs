using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrendyolMVC2016.Models
{
    public class Storage
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Status { get; set; }
        public virtual Order Order { get; set; }
    }
}