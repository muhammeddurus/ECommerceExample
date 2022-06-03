using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESalesDataEntities.Model
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        
        public int? City_ID { get; set; }
        [ForeignKey("City_ID")]
        public virtual City City { get; set; }
        
        public int? Customer_ID { get; set; }
        [ForeignKey("Customer_ID")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
