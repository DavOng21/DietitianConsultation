using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietitianConsultation.Shared.Domain
{
    public class PatientInfo : BaseDomainModel
    {
        public int BMI { get; set; }
        public string MedicalHistory { get; set; }
        public string ActivityRate { get; set; }
        public string Goals { get; set; }
        public int TargetWeight { get; set; }
        public int TargetHeight { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
