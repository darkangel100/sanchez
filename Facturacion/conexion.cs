﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Facturacion
{
    class conexion
    {
    
            String connectionString = "Database =facturacion ;Data Source=localhost;User Id=root; Password=";
            public MySqlConnection GetConnection()
            {
                MySqlConnection objcon = new MySqlConnection(connectionString);
                return objcon;
            }
        
        
    }
}
