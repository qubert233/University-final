using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbLections")]
    public class Lection: AbstractDbEntity
    {
        [Column(TypeName = "datetime")]
        public DateTime Start { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Finish { get; set; }
        public DayOfWeek Day { get; set; }
        public List<AudLect> AudLects { get; set; }
    }
}
