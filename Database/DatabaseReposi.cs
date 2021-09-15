using Online_Food_Order_Software.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Order_Software.Database
{
    class DatabaseReposi: DbContext
    {
        public DbSet<Customer> buyer { get; set; }
        public DbSet<Feedback> response { get; set; }

        public DbSet<promo> promotion { get; set; }

        public DbSet<Class1> class1s_set { get; set; }
        public DbSet<Delivery1> deliveries_set { get; set; }
        public DbSet<Suplier> supliers_set { get; set; }

        public DbSet<Payment> payments_set { get; set; }

    }
}
