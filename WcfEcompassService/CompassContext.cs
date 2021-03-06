﻿using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfEcompassService
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CompassContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CompassContext() : base("name=PNPContext")
        {
        }

        public System.Data.Entity.DbSet<PnpProducts> Products { get; set; }
        //public System.Data.Entity.DbSet<PNP.Models.PnpEmployee> Employees { get; set; }
        //public System.Data.Entity.DbSet<PNP.Models.PnpManager> Managers { get; set; }
        //public System.Data.Entity.DbSet<PNP.Models.PnpSales> Sales { get; set; }
        //public System.Data.Entity.DbSet<PNP.Models.PnpSpecial> Specials { get; set; }
        //public System.Data.Entity.DbSet<PNP.Models.PnpLocation> Locations { get; set; }
        //public System.Data.Entity.DbSet<PNP.Models.ProductCatagory> ProductCatagories { get; set; }

    }
}
