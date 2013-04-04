using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//added this


namespace APIwithEF.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]//tells MVC to skip Id field when generating an editor form
        public int Id { get; set; }
        [Required]//specifies that name must be non-empty string
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ActualCost { get; set; }

    }
    
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }

        // Navigation property
        public ICollection<OrderDetail> OrderDetails { get; set; }//allows you to find the related orderdetail
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}