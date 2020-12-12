using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntryPoint___test_task.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required, StringLength(80, MinimumLength = 1), Display(Name = "Code")]
        public string Code { get; set; }

        [Required,StringLength(200, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

    }
}
