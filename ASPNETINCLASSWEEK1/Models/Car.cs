using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASPNETINCLASSWEEK1.Models
{
    public class Car
    {
        //Simple car properties
        [Key]
        public int Car_ID { get; set; }

        [Required]
        [RegularExpression("..+")]
        public string Model { get; set; }

        [Range(10,300)]
        public double MaxSpeed { get; set; }
        public string ImageName { get; set; }
    }
} 