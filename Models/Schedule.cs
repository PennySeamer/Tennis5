using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tennis5.Models
{
    public partial class Schedule
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public DateTime When { get; set; }
        public string Description { get; set; }
        public string CoachEmail { get; set; }
        public string Location { get; set; }
    }
}
