﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PM_Ban_Hang_Sieu_Thi.APP_DATA
{
    public class Connector
    {
        public Connector() { }
        public String getconnect()
        {
            return (ConfigurationManager.ConnectionStrings["Conn"].ToString());
        }
    }
}
