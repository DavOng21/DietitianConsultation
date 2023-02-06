using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietitianConsultation.Shared.Domain
{
    public class PatientInfo : BaseDomainModel
    {
        [Required]
        public int BMI { get; set; }
        [Required]
        public string MedicalHistory { get; set; }
        [Required]
        public string ActivityRate { get; set; }
        public string Goals { get; set; }
        [Required]
        public int TargetWeight { get; set; }
        [Required]
        public int TargetHeight { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientId { get; set; }

    }
}
