using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbPhones")]
    public class Phone: AbstractDbEntity
    {
        [StringLength(64)]
        public string StudentsPhone { get; set; }
        public virtual Student Student { get; set; }
    }
}
