using System;
using System.ComponentModel.DataAnnotations;

namespace EventuresApp.Models
{
    public class EventCreateBindingModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Place")]
        public string Place { get; set; }

        [Required]
        [Display(Name = "Start")]
        public DateTime Start { get; set; }

        [Required]
        [Display(Name = "End")]
        public DateTime End { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Total tickets mast be pozitiv number!")]
        [Display(Name = "TotalTickets")]
        public int TotalTickets { get; set; }

        [Required]
        [Range(0.00, double.MaxValue, ErrorMessage = "Price Per Ticket mast be pozitiv number!")]
        [Display(Name = "PricePerTicket")]
        public double PricePerTicket { get; set; }

    }
}
