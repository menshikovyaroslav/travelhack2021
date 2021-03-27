using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель Клиент
    /// </summary>
    [Table("clients")]
    public class Client
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        [Column("id")]
        public long Id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        [Column("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        [Column("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        [Column("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата создания клиента
        /// </summary>
        [Column("created")]
        public DateTime Created { get; set; }
    }
}