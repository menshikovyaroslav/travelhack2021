using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Событие
    /// </summary>
    [Table("events")]
    public class Event
    {
        /// <summary>
        /// Идентификатор события
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название события
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Дата события
        /// </summary>
        [Column("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Регулярность события, true - регулярное, false - нет
        /// </summary>
        [Column("is_regulary")]
        public string IsRegulary { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        [Column("patronymic")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Описание события
        /// </summary>
        [Column("description")]
        public string Description { get; set; }

        /// <summary>
        /// Картинка для события
        /// </summary>
        [Column("image")]
        public string Image { get; set; }


    }
}