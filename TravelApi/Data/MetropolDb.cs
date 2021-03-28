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
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// События в компании
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Ордера компании
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Помещения компании
        /// </summary>
        public DbSet<Space> Spaces { get; set; }

        /// <summary>
        /// Типы помещений компании
        /// </summary>
        public DbSet<SpaceType> SpaceTypes { get; set; }

        /// <summary>
        /// Условия помещений компании
        /// </summary>
        public DbSet<SpaceCondition> SpaceConditions { get; set; }

        /// <summary>
        /// Услуги компании
        /// </summary>
        public DbSet<Service> Services { get; set; }

        /// <summary>
        /// Типы услуг компании
        /// </summary>
        public DbSet<ServiceType> ServiceTypes { get; set; }

        /// <summary>
        /// Заказы в ресторан
        /// </summary>
        public DbSet<RestaurantOrder> RestaurantOrders { get; set; }

        /// <summary>
        /// Меню ресторана
        /// </summary>
        public DbSet<Menu> Menus { get; set; }

        public MetropolDb(DbContextOptions<MetropolDb> options) : base(options) { }
    }
}