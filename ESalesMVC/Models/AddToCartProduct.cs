using ESalesDataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESalesMVC.Models
{
    public  class AddToCartProduct
    {
        public static ICollection<Product> Products { get; set; }
    }
}