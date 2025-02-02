﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FamilyType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public ICollection<Family> Families { get; set; }
    }
}
