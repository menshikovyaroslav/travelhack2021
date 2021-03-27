using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using TravelApi.Models;

namespace TravelApi.Data
{
    public static class Database
    {
        readonly static string connString = WebConfigurationManager.AppSettings["conn_string"];
        public static List<Client> GetClients()
        {
            try
            {
                using (var db = new MetropolDb(new DbContextOptionsBuilder<MetropolDb>().UseNpgsql(connString).Options))
                {
                    return db.Clients.ToList();
                }
            }
            catch (Exception)
            {
            }

            return new List<Client>();
        }
    }
}