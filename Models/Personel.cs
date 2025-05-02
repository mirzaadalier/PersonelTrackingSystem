using System;
using System.ComponentModel.DataAnnotations;

namespace PersonnelTrackingSystem.Models
{
    public class Personel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Department { get; set; }

        public DateTime EntryTime { get; set; } = DateTime.Now;

        public DateTime? ExitTime { get; set; }
    }
}
