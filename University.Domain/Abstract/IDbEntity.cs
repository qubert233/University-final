using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Domain
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
