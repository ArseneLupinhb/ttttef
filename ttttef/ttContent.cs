using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ttttef
{
    class ttContent: DbContext
    {
        public ttContent():base("name=DBConnectionString")
        { }

        public DbSet<teacther> Teacther { get; set; }
    }
}
