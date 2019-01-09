using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbDepartments")]
    public class Department: AbstractDbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}
