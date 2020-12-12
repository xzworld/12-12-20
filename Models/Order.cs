using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntryPoint___test_task.Models
{
    public enum Status {

    Created, Paid, Delivered

    }

    public class Order
    {
        public int ID { get; set; }

        [Required, StringLength(40, MinimumLength = 1), Display(Name = "Client Id")]
        public int ClientId { get; set; }
         
        public string Client { get; set; }

        [Required, StringLength(40, MinimumLength = 1), Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Required, Display(Name = "Products")]
        public ICollection<Product> Products { get; set; }

        [Required]
        public int Quantity { get; set; }

        [EnumDataType(typeof(Status))]
        public Status? Status { get; set; }



 



    }
}
