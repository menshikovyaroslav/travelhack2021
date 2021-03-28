using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Тип помещения
    /// </summary>
    [Table("space_types")]
    public class SpaceType
    {
        /// <summary>
        /// Идентификатор типа помещения
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название типа помещения
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}