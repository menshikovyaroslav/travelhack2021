using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Заказ в ресторан
    /// </summary>
    [Table("restaurant_orders")]
    public class RestaurantOrder
    {
        /// <summary>
        /// Идентификатор заказа
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор меню
        /// </summary>
        [Column("menu_id")]
        public int MenuId { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [Column("count")]
        public int Count { get; set; }
    }
}