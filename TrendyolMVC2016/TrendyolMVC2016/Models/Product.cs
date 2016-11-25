using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrendyolMVC2016.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [StringLength(50)]
        [Required]
        [DisplayName("Product Code")]
        public string ProductCode { get; set; }
        //Status = 0 (Product Wont Sell Anymore) //Status = 1 (Product Can Sell)
        public int Status { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}