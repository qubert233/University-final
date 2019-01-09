using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbSpeciality")]
    public class Speciality : AbstractDbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual List<Group> Groups { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
