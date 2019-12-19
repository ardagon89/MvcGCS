using System;
using System.ComponentModel.DataAnnotations;

namespace GCS.Models
{
    public class OutcomeAssessmentViewModel
    {
        [Key]
        public Guid guid { get; set; }
        public Outcome outcome { get; set; }
        public Assessment assessment { get; set; }
    }
}
