using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string phone_num{ get; set; }
    }
}
