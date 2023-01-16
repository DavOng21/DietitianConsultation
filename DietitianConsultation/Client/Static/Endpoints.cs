using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietitianConsultation.Client.Static
{
    public static class Endpoints
    {
        public static readonly string Prefix = "api";

        public static readonly string PatientsEndpoint = $"{Prefix}/patients";
        public static readonly string PatientInfosEndpoint = $"{Prefix}/patientinfos";
        public static readonly string FoodsEndpoint = $"{Prefix}/foods";
        public static readonly string NutritionListsEndpoint = $"{Prefix}/nutritionlists";

    }
}
