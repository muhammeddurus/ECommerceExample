using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESalesDataEntities.Model
{
    public class Supplier
    {
        [Key]
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
