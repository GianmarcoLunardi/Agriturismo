using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Agriturismo.Models
{
    public class Appartament
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLengthRange(MaximumLength = 15)]
        public string Name { get; set; }
        [DefaultValue(null)]
        public string?  Description_It { get; set; }
        [DefaultValue(null)]
        public string? Description_Us { get; set; }
        [DefaultValue(null)]
        public int  DoubleBed { get; set; }
        [DefaultValue(0)]
        public int ExtraBed { get; set; }
        [DefaultValue(0)]
        public int  SofàBed { get; set; }
    }
}
