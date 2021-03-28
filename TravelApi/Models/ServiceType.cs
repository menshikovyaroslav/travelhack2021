using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Тип Услуги
    /// </summary>
    [Table("service_types")]
    public class ServiceType
    {
        /// <summary>
        /// Идентификатор типа услуги
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название типа услуги
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}