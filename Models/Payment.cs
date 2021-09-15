using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class Payment
    {
        [Key]
        public int Payment_ID { get; set; }
        public string User_Name { get; set; }
        public string Card_Holder_Name { get; set; }

        public string Payment_Method { get; set; }

        public string Card_Type { get; set; }
        public string Card_Number { get; set; }
        public string Expire_Month { get; set; }
        public string Expire_Year { get; set; }
        public string Security_Code { get; set; }
        public string Payment_Date { get; set; }




    }
}
