using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietitianConsultation.Shared.Domain
{
    public class NutritionList : BaseDomainModel
    {
        public int TotalCarb { get; set; }
        public int Calcium { get; set; }
        public int Cholesterol { get; set; }
        public int Sodium { get; set; }
        public int TransFat { get; set; }
        public int TotalFat { get; set; }
        public int SaturatedFat { get; set; }
        public int Protein { get; set; }
        public int VitaminA { get; set; }
        public int VitaminC { get; set; }
        public int VitaminD { get; set; }
        public int TotalSugar { get; set; }
        public int DietaryFiber { get; set; }
        public int Iron { get; set; }
        public int Potassium { get; set; }
        public virtual Food Food { get; set; }
        public int FoodId { get; set; }
    }
}
