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
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [StringLength(15)]
        public string Surname { get; set; }
        [Required]

        
        [StringLength(35)]
        public string Address { get; set; }
        [Required]

        public string City { get; set; }
        [Required]


        public string Zip { get; set; }
        [Required]

  
        public string Country { get; set; }
        [Required]

        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }

        [DataType(DataType.EmailAddress)]

        public string mail { get; set; }






    }
}
