using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public int? CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int? Quantity  { get; set; }
        [Required]
        public double? Price { get; set; }


    }
}
