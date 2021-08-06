using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Agriturismo.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(15)]
        public String Name { get; set; }
        [MaxLength(15)]
        public String Surnamer { get; set; }
        [MaxLength(50)]
        public String Address { get; set; }
        [MaxLength(15)]
        public String City { get; set; }
        [MaxLength(15)]
        public String Zip { get; set; }
        [MaxLength(15)]
        public String Country { get; set; }
        [MaxLength(15)]

        public String Phone { get; set; }


    }
}
