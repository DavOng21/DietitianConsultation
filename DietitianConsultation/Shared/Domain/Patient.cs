using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietitianConsultation.Shared.Domain
{
    public class Patient : BaseDomainModel
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public int Contact { get; set; }
    }
}
