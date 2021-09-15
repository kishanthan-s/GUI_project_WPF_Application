using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class Delivery1
    {
        [Key]
        public int Delivery_ID1 { get; set; }
        public string User_name { get; set; }
        public string Customer_ID { get; set; }

        public string Customer_Name { get; set; }
        public string Email { get; set; }


        public string Door_No { get; set; }
        public string Apartment_Name { get; set; }
        public string Street_name { get; set; }
        public string Landmark { get; set; }

        public string City { get; set; }
        public string Province { get; set; }

        public string Place { get; set; }


    }
}
