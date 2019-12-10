using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        [Required]
        [Display(Name = "Meeting Date")]
        public int MeetingID { get; set; }

        [Required]
        [Display(Name = "Speaker")]
        [StringLength(100, MinimumLength = 3)]
        public string SpeakerName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Subject { get; set; }
    }
}
