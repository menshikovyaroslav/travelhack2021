using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Ордер - документ об услуге
    /// </summary>
    [Table("orders")]
    public class Order
    {
        /// <summary>
        /// Идентификатор ордера
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        [Column("date_from")]
        public DateTime DateFrom { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        [Column("date_to")]
        public DateTime DateTo { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [Column("cost")]
        public int Cost { get; set; }

        /// <summary>
        /// Идентификатор помещения
        /// </summary>
        [Column("space_id")]
        public int SpaceId { get; set; }

        /// <summary>
        /// Емкость
        /// </summary>
        [Column("capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Идентификатор заказа в ресторан
        /// </summary>
        [Column("restaurant_order_id")]
        public int RestaurantOrderId { get; set; }

        /// <summary>
        /// Идентификатор события
        /// </summary>
        [Column("event_id")]
        public int EventId { get; set; }
    }
}