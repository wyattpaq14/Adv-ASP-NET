using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASPNETINCLASSWEEK1.Models
{
    public class Manufactruer
    {

        [Key]
        public int Manufactruer_ID { get; set; }

        [Required(ErrorMessage ="Car Manufacturer is required")]
        [RegularExpression("..+", ErrorMessage = "Must be atleast 2 characters long")]

        public string Make { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}