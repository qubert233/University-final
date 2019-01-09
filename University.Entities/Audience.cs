using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbAudiences")]
    public class Audience: AbstractDbEntity
    {
        [StringLength(32)]
        public string Name { get; set; }
        public List<AudLect> AudLects { get; set; }
    }
}
