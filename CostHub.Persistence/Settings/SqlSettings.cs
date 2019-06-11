using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Persistence.Settings
{
    public class SqlSettings
    {
        public string Database { get; set; }
        public string Server { get; set; }
        public string ConnectionString { get; set; }
        public SqlSettings(string db, string srv)
        {
            Database = db;
            Server = srv;
            ConnectionString = $"Server={Server};Database={Database};Trusted_Connection=True;";
        }
    }
}
