using RightsLine.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RightsLine.Infrastructure
{
    public class RecordDb : DbContext
    {
        public RecordDb(): base("DefaultConnection")
        {

        }

        public DbSet<Record> Records { get; set; }
    }
}