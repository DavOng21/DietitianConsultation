using DietitianConsultation.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietitianConsultation.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Patient> Patients { get; }
        IGenericRepository<PatientInfo> PatientInfos { get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<NutritionList> NutritionLists { get; }

    }
}