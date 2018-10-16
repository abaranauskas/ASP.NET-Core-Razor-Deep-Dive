using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Models
{
    public class Order
    {
        [Required(ErrorMessage = "We need to know who they are!")]
        public string ClientId { get; set; }
        [Required(ErrorMessage = "The Company Name is a must!")]
        public string CompanyName { get; set; }
        [Required]
        public string OrderDate { get; set; }
        [Required]
        public string Stage { get; set; }
        public List<OrderProductVM> Products { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public string OrderInstructions { get; set; }
        [Required]
        [MaxLength(25)]
        public string Notes { get; set; }
    }

    public class OrderProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
    }
}
