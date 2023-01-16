using DietitianConsultation.Server.Data;
using DietitianConsultation.Server.IRepository;
using DietitianConsultation.Server.Models;
using DietitianConsultation.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DietitianConsultation.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Patient> _patients;
        private IGenericRepository<PatientInfo> _patientinfos;
        private IGenericRepository<Food> _foods;
        private IGenericRepository<NutritionList> _nutritionlists;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Patient> Patients
           => _patients ??= new GenericRepository<Patient>(_context);
        public IGenericRepository<PatientInfo> PatientInfos
            => _patientinfos ??= new GenericRepository<PatientInfo>(_context);
        public IGenericRepository<Food> Foods
            => _foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<NutritionList> NutritionLists
            => _nutritionlists ??= new GenericRepository<NutritionList>(_context);
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
