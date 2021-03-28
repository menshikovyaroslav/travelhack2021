using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Услуги
    /// </summary>
    [Table("services")]
    public class Service
    {
        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название услуги
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Цена услуги
        /// </summary>
        [Column("cost")]
        public int Cost { get; set; }

        /// <summary>
        /// Идентификатор типа услуги
        /// </summary>
        [Column("service_type_id")]
        public int ServiceTypeId { get; set; }
    }
}