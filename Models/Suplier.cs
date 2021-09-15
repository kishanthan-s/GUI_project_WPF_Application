using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Models
{
    class Suplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Suplier_ID { get; set; }
        public string Name { get; set; }
        public string Contact_No { get; set; }

        public string Vehical_No { get; set; }
        public string Province { get; set; }

    }
}
