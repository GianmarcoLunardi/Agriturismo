using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Agriturismo.Models
{
    public class Reservation
    {
        public DateTime Date { get; set; }

        [Key]
        public int Id { get; set; }

        public Appartament Appartament  { get; set; }
        public Guest Guest { get; set; }

        public String Note { get; set; }

    }
}
