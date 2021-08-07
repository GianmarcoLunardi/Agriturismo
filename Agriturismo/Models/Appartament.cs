using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Agriturismo.Models
{
    public class Appartament
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Description_It { get; set; }
        public string Description_Us { get; set; }
        public int?  DoubleBed { get; set; }
        public int? ExtraBed { get; set; }
        public int?  SofàBed { get; set; }
    }
}
