using DataLayer.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Data.DBContext
{
    public class DBMainContext : DbContext
    {
        public DBMainContext(DbContextOptions<DBMainContext> options) : base(options)
        {

        }

        public DbSet<TBProducts> Products { get; set; }
        public DbSet<TBOrders> Orders { get; set; }
    }
}
