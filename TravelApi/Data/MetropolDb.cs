using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelApi.Models;

namespace TravelApi.Data
{
    /// <summary>
    /// Контекст данных работы с БД Метрополь
    /// </summary>
    public class MetropolDb : DbContext
    {
        /// <summary>
        /// Клиенты компании
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        public MetropolDb(DbContextOptions<MetropolDb> options) : base(options) { }
    }
}