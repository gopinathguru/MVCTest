using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}