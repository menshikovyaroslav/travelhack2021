using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Условия помещения
    /// </summary>
    [Table("space_conditions")]
    public class SpaceCondition
    {
        /// <summary>
        /// Идентификатор Условия помещения
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название Условия помещения
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}