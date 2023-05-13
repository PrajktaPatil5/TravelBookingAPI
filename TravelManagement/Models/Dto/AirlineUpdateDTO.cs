﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelManagement.Models.Dto
{
    public class AirlineUpdateDTO
    {
        [Required]
        public int Id { get; set; }


        [Required]
        [RegularExpression("^[a-zA-Z ]+$")]
        [StringLength(50)]
        public string AirlineName { get; set; }

        [RegularExpression("^[a-zA-Z0-9 ]+$")]
        [StringLength(10)]
        public string AirlineCode { get; set; }
        //public ICollection<Flight> Flights { get; set; }
    }
}
