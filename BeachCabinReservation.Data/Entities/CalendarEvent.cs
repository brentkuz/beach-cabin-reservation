using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BeachCabinReservation.Data.Entities
{
    [Table("CalendarEvents")]
    public class CalendarEvent : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsAllDay { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [ForeignKey("Owner")]
        public string OwnerId { get; set; }
        public AppUser Owner { get; set; }
    }
}
