using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Agriturismo.Models
{
    public class Scheduler
    {
       [Key]
       public long id { get; set; }
       public int ApprartamentiID { get; set; }
       public  DateTime Day { get; set; }
       public int ReservationId { get; set; }

    }
}
