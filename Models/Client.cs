using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntryPoint___test_task.Models
{

    public enum Gender
    {
        Male, Female
    }

    public class Client
    {
        public int ID { get; set; }
        
        [Required, StringLength(60, MinimumLength = 3), Display(Name = "Name")]
        public string Name { get; set; }
        
        [Required, StringLength(100, MinimumLength = 6), RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
        
        [Required, Display(Name = "Birth date"), DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        
        [EnumDataType(typeof(Gender)), Display(Name = "Gender")]
        public Gender? Gender { get; set; }

        //public string Orders { get; set; }
        [Display(Name = "Order")]
        public ICollection<Order> Orders { get; set; }

    }
}
