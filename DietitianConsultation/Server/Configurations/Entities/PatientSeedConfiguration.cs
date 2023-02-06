using DietitianConsultation.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietitianConsultation.Server.Configurations.Entities
{
    public class PatientSeedConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasData(
        new Patient
        {
            Id = 1,
            Name = "Joe",
            Gender = "Male",
            Address = "Tampines Street 21 blk 123",
            DateOfBirth= new DateTime(2001, 3, 23),
            Contact = "88833323",
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"
        },
        new Patient
        {
            Id = 2,
            Name = "Steven",
            Gender = "Male",
            Address = "Tampines Street 21 blk 123",
            DateOfBirth = new DateTime(2003, 6, 15),
            Contact = "92856722",
            DateCreated = DateTime.Now,
            DateUpdated = DateTime.Now,
            CreatedBy = "System",
            UpdatedBy = "System"
        }
) ;
         


        }
    }
}
