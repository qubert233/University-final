using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbSubjects")]
    public class Subject: AbstractDbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public IList<TeachSubj> TeachSubj { get; set; }
    }
}
