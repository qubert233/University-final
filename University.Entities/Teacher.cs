﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University.Domain;

namespace Domain.Entities
{
    [Table("tbTeachers")]
    public class Teacher : AbstractDbEntity
    {
        [StringLength(64)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(64)]
        public string LastName { get; set; }
        public virtual Department Department { get; set; }
        public IList<TeachSubj> TeachSubj { get; set; }

        public override string ToString()
        {
           return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
