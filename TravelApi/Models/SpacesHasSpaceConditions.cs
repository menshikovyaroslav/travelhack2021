using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelApi.Models
{
    /// <summary>
    /// Модель сопоставления помещения с условиями помещения
    /// </summary>
    [Table("spaces_has_space_conditions")]
    public class SpacesHasSpaceConditions
    {
        /// <summary>
        /// Идентификатор помещения
        /// </summary>
        [Column("space_id")]
        public int SpaceId { get; set; }

        /// <summary>
        /// Идентификатор состояния
        /// </summary>
        [Column("space_condition_id")]
        public int SpaceConditionId { get; set; }
    }
}