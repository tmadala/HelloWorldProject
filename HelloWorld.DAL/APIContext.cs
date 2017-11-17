using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HelloWorld.DAL
{
    
   public class APIContext : DbContext
    {
        public APIContext() : base("DefaultConnection")
        {
        }
        public DbSet<Products> products { get; set; }

    }
}
