using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventFlow.Models
{
    public class Event
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string Location { get; set; }
        [Required] public DateTime EventDate { get; set; }
        [Required] public string Category { get; set; }
        [Required] public string ImageUrl { get; set; }

        [Required] public int AttendeeNumber { get; set; }
    }
}