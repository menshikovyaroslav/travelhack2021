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
        /// Метод получения всех пользователей
        /// </summary>
        /// <returns></returns>
        public static List<User> GetUsers()
        {
            try
            {
                using (var db = new MetropolDb(new DbContextOptionsBuilder<MetropolDb>().UseNpgsql(connString).Options))
                {
                    return db.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                Log.Instance.Error(1, ex.Message);
            }

            return new List<User>();
        }

        /// <summary>
        /// Метод получения пользователя по его идентификатору
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public static User GetUserById(int userId)
        {
            try
            {
                using (var db = new MetropolDb(new DbContextOptionsBuilder<MetropolDb>().UseNpgsql(connString).Options))
                {
                    return db.Users.SingleOrDefault(c => c.Id == userId);
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