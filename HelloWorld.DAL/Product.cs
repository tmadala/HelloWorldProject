using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld.DAL
{
    [Table("products")]
    public class Products
    {
        [Key]
        public int slNO { get; set; }

        [Required(ErrorMessage = "Product Id is Needed.")]
        public Int64? productId { get; set; }
        [Required(ErrorMessage = "Product Name is Required.")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is Required.")]
        public int Price { get; set; }

    }
}

