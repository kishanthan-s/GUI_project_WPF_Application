using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class Class1
    {

        [Key]
        public int Cart_ID1 { get; set; }

        public string Customer_Name { get; set; }

        public string Item_ID { get; set; }

        public string Item_Name { get; set; }
        public int Item_Prize { get; set; }
        public int Quantity { get; set; }
        public int Total_prize { get; set; }

        public int Buy_Scussess { get; set; }//select 1//cancel 0//buy 2//


    }
}
