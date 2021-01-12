using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECT.Entities.Base
{
    public class EntityBase
    {
        [Key]
        [Column("ID")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
