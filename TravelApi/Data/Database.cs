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
        /// <summary>
        /// Строка подключения к базе данных
        /// </summary>
        readonly static string connString = WebConfigurationManager.AppSettings["connectionString"];

        /// <summary>
        /// Метод получения всех клиентов
        /// </summary>
        /// <returns></returns>
        public static List<Client> GetClients()
        {
            try
            {
                using (var db = new MetropolDb(new DbContextOptionsBuilder<MetropolDb>().UseNpgsql(connString).Options))
                {
                    return db.Clients.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Instance.Error(1, ex.Message);
            }

            return new List<Client>();
        }

        /// <summary>
        /// Метод получения клиента по его идентификатору
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public static Client GetClient(long clientId)
        {
            try
            {
                using (var db = new MetropolDb(new DbContextOptionsBuilder<MetropolDb>().UseNpgsql(connString).Options))
                {
                    return db.Clients.SingleOrDefault(c => c.Id == clientId);
                }
            }
            catch (Exception ex)
            {
                Log.Instance.Error(2, ex.Message);
            }

            return null;
        }
    }
}