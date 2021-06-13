using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public  decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }

        public Item()
        {
            Title = "";
            Description = "";
            Price = 0.0M;
            Sold = false;
            PaymentDistributed = false;
            Owner = new Vendor();
        }

        public string Display 
        {
            get
            {
                return string.Format($"{Title} - ${Price}");
            }
        }

    }
}
