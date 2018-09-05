using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCricketer.Models
{
    public class Cricketer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ODI { get; set; }
        public int Test { get; set; }
    }
    public class CricketerDBContext : DbContext
    {
        public DbSet<Cricketer> Cricketers { get; set; }

    }
}