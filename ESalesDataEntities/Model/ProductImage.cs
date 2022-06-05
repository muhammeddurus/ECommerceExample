using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESalesDataEntities.Model
{
    public class ProductImage
    {
        [Key]
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public int? Product_ID { get; set; }
        [ForeignKey("Product_ID")]
        public virtual Product Product { get; set; }
    }
}
