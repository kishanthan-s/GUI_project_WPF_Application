﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class Feedback
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
