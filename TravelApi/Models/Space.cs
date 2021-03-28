using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Помещение
    /// </summary>
    [Table("spaces")]
    public class Space
    {
        /// <summary>
        /// Идентификатор помещения
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название помещения
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Емкость помещения
        /// </summary>
        [Column("capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Идентификатор типа помещения
        /// </summary>
        [Column("space_type_id")]
        public int SpaceTypeId { get; set; }
    }
}