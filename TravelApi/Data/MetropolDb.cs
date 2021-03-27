using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelApi.Models;

namespace TravelApi.Data
{
    public class MetropolDb : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public MetropolDb(DbContextOptions<MetropolDb> options) : base(options) { }
    }
}