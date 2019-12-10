using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [Display(Name = "Conducting")]
        [StringLength(100, MinimumLength = 3)]
        public string ConductingLeader { get; set; }

        [Required]
        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }

        [Required]
        [Display(Name = "Sacrament Song")]
        public string SacramentSong { get; set; }

        [Display(Name = "Intermediate Song")]
        public string IntermediateSong { get; set; }

        [Required]
        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        [StringLength(100, MinimumLength = 3)]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        [StringLength(100, MinimumLength = 3)]
        public string ClosingPrayer { get; set; }

        public List<Speaker> Speakers { get; set; }
    }
}


