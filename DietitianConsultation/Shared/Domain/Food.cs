using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietitianConsultation.Shared.Domain
{
    public class Food : BaseDomainModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
        public int ServingSize { get; set; }

    }
}
