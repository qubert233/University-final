using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbTeachSubj")]
    public class TeachSubj: AbstractDbEntity
    {
        public Guid TeacherId { get; set; }
        public Guid SubjId { get; set; }
        public Teacher Teacher { get; set; }
        public Subject Subject { get; set; }
        public virtual List<Mark> Marks { get; set; }
        public virtual List<AudLect> AudLects { get; set; }
    }
}
