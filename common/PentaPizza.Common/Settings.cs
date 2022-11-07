using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PentaPizza.Common
{
    public class Settings
    {
        public DatabaseSettings Database { get; set; }

        public class DatabaseSettings
        {
            public string ConnectionString { get; set; }
        }
    }
}