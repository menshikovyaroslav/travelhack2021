using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using TravelApi.Classes;
using TravelApi.Models;

namespace TravelApi.Data
{
    public static class Database
    {
        readonly static string connString = WebConfigurationManager.AppSettings["connectionString"];
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

        public static Client GetClient(long clientId)
        {
            try
            {
                using (var db = new MetropolDb(new DbContextOptionsBuilder<MetropolDb>().UseNpgsql(connString).Options))
                {
                    return db.Clients.SingleOrDefault(c => c.Id == clientId);
                }
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}