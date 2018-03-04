using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNETINCLASSWEEK1.Models
{
    public class ASPNETINCLASSWEEK1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ASPNETINCLASSWEEK1Context() : base("name=ASPNETINCLASSWEEK1Context")
        {
        }

        public System.Data.Entity.DbSet<ASPNETINCLASSWEEK1.Models.Manufactruer> Manufactruers { get; set; }

        public System.Data.Entity.DbSet<ASPNETINCLASSWEEK1.Models.Car> Cars { get; set; }
    }
}
