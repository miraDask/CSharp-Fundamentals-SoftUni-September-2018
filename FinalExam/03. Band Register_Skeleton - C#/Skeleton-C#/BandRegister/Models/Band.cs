﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BandRegister.Models
{
    public class Band
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Members { get; set; } 

        [Required]
        public double Honorarium { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}
