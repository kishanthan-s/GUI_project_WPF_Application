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

        
        [Key]
        public int PromoId { get; set; }

        public int Customer_ID { get; set; }
        public string Item { get; set; }

        public string Item_Name { get; set; }
        public int Item_Prize { get; set; }
        public int Quantity { get; set; }
        public int Total_prize { get; set; }

    }
}
