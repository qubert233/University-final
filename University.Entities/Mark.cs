using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbMarks")]
    public class Mark: AbstractDbEntity
    {
        [Range(0,100)]
        public int StudentsMark { get; set; }
        public virtual Student Student { get; set; }
        public virtual TeachSubj TeachSubj { get; set; }

    }
}
