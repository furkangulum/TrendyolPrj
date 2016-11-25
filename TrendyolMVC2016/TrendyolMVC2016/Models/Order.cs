using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrendyolMVC2016.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public int Status { get; set; }
        public virtual Product Product { get; set; }

    }
}