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
    [Table("users")]
    public class User
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

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
        [Column("patronymic")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Телефон клиента
        /// </summary>
        [Column("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Email клиента
        /// </summary>
        [Column("email")]
        public string EMail { get; set; }

        /// <summary>
        /// Дата создания клиента
        /// </summary>
        [Column("created")]
        public DateTime Created { get; set; }
    }
}