using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Persistence
{
    public class CostHubContext: DbContext
    {
        public CostHubContext(string conn):base(nameOrConnectionString: conn)
        {
            Database.SetInitializer<CostHubContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new TestConfiguration());
        }
    }
}
