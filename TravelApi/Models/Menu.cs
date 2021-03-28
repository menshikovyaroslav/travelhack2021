using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Меню
    /// </summary>
    [Table("menu")]
    public class Menu
    {
        /// <summary>
        /// Идентификатор меню
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название меню
        /// </summary>
        [Column("name")]
        public string Name { get; set; }


        /// <summary>
        /// Цена
        /// </summary>
        [Column("cost")]
        public int Cost { get; set; }
    }
}