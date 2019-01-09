using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbAudLect")]
    public class AudLect: AbstractDbEntity
    {
        public Guid AudId { get; set; }
        public Guid LectId { get; set; }
        public Guid GroupId { get; set; }
        public Audience Audience { get; set; }
        public Lection Lection { get; set; }
        public Group Group { get; set; }
        public virtual TeachSubj TeachSubj { get; set; }
    }
}
