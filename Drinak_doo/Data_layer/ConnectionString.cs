﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class ConnectionString
    {
        private static string connectionString = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=xe)));User Id=vanja;Password=admin;";
        
        public static string GetString()
        {
            return connectionString;
        }
    }
}
