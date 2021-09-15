using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class promo
    {
        [Key,Column(Order=0)]
        public string customerID { get; set; }
        [Key, Column(Order = 1)]
        public string itemID { get; set; }

        public string itemPrice { get; set; }

        public string discount { get; set; }
    }
}
